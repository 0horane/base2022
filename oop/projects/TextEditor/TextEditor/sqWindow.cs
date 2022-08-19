using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    internal class sqWindow
    {
        /*TODO input keys have to be moved over 
            https://docs.microsoft.com/en-us/windows/console/classic-vs-vt
            https://docs.microsoft.com/en-us/windows/console/readconsoleinput
            
        https://github.com/silkfire/Pastel/blob/master/src/ConsoleExtensions.cs

            to windwos. the handler would only decide which windows to delegate to. therfore i think the window 
            manager should contain the input handler 
        */

        private int width, height, xoffset, yoffset, scrollY, lastwrappedlines = 0, skippedlines=4;
        private Tab tab;
        public sqWindow(Tab? tab = null, int ? width = null, int? height = null, int xoffset = 0, int yoffset = 0, int scrollY=0)
        {
            this.width = width ?? Console.WindowWidth;
            this.height = height ?? Console.WindowHeight;
            this.xoffset = xoffset;
            this.yoffset = yoffset;
            this.tab = tab ?? new Tab();
            this.scrollY = scrollY;
        }

        public void testrender()
        {
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            scrollY =  Math.Max(0, tab.CursorY - height / 3 * 2);
            //gets necesary data to print
            string[] content = tab.getContent().ToArray();
            int cursorX = tab.CursorX;
            int cursorY = tab.CursorY;
            //starts printing title at top
            Console.SetCursorPosition(0, yoffset);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(tab.Title + new string(' ', width - tab.Title.Length));
            Console.ResetColor();
            //function has to be declared locally because no params (dumb way of doing things but ok)
            string statusLine()
            {
                return $"char {cursorX}/{content[cursorY].Length - 1}, row {cursorY}/{content.Length - 1}   on:\"{((tab.getCharAt() == tab.Newlinechar) ? "\\n" : tab.getCharAt())}\"  scroll {yoffset}  window {width}/{height}";
            }

            string outputext = "";
            int linessofar, j, cpos=0;
            //while we need more lines to fit the height and the text still ahs more lines:
            for (linessofar = 0, j = scrollY; linessofar < height - skippedlines && j < content.Length; j++)
            {
                //split each line into sublines according to width
                for (var i = 0; i < content[j].Length && linessofar < height - skippedlines; i += width)
                {
                    //if (j == cursorY && i <= cursorX && cursorX < i+ width)
                    string localsubstring = content[j].Substring(i, Math.Min(width, content[j].Length - i));
                    localsubstring += new string(' ', width - localsubstring.Length);
                    outputext += localsubstring + tab.Newlinechar;
                    linessofar++;
                    if (j<cursorY || (j == cursorY && cursorX > i+width-1 ))
                        cpos++;
                    
                    
                }
                if (content[j].Length == 0)
                {
                    outputext += new string(' ', width) + tab.Newlinechar;
                    linessofar++;
                    if (j < cursorY)
                        cpos++;
                    

                }


            }
            //pads bottom if cursor at lowest possible
            if(height - linessofar - skippedlines > 0)
            {
                string newlines = string.Concat(Enumerable.Repeat(new string(' ', width) + tab.Newlinechar, 1+height - linessofar - skippedlines));
                outputext += newlines.Substring(0,newlines.Length-1);

            }

            lastwrappedlines = cpos - linessofar;
            //writes whole text + statusline
            Console.Write(outputext + '\n');
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(statusLine()+ new string(' ', width - statusLine().Length));
            Console.ResetColor();
            Console.SetCursorPosition((cursorX % width) , cpos+1+ yoffset);


            /*Console.WriteLine();
            for (int i = scrollY; i < Math.Min(scrollY + height - 1, content.Count - scrollY); i++) {
                Console.WriteLine(content[i]);
            }
            if (height -1 > content.Count - scrollY)
            {
                for (int i = 0; i < height - 1 - (content.Count - scrollY)-1 ; i++)
                {
                    Console.WriteLine();

                }
            }
            Console.WriteLine($"{cursorX}/{content[cursorY].Length-1} {cursorY}/{content.Count-1} {debugvar}");
            */
        }

        public void testRunCommand(ConsoleKeyInfo pkey) {

            switch (pkey.Key)
            {
                case ConsoleKey.S:
                    if ((pkey.Modifiers & ConsoleModifiers.Control) != 0)
                        tab.write();
                    else
                        tab.add(pkey.KeyChar.ToString());
                    break;
                case ConsoleKey.Enter:
                    tab.add(tab.Newlinechar);
                    break;
                case ConsoleKey.Escape:
                    tab.esc();
                    break;
                case ConsoleKey.Tab:
                    tab.add("    ");
                    break;
                case ConsoleKey.Backspace:
                    tab.rm(-1);
                    break;
                case ConsoleKey.Delete:
                    tab.rm(1);
                    break;
                case ConsoleKey.RightArrow:
                    if ((pkey.Modifiers & ConsoleModifiers.Control) != 0)
                        tab.movecurX(tab.getWord(1));
                    else
                        tab.movecurX(1);
                    break;
                case ConsoleKey.LeftArrow:
                    if ((pkey.Modifiers & ConsoleModifiers.Control) != 0)
                        tab.movecurX(tab.getWord(-1));
                    else
                        tab.movecurX(-1);
                    break;
                case ConsoleKey.UpArrow:
                    tab.movecurY(-1);
                    break;
                case ConsoleKey.DownArrow:
                    tab.movecurY(1);
                    break;
                default:
                    tab.add(pkey.KeyChar.ToString());
                    break;
            }
            testrender();

        }

        public void dlltestRunCommand(AConsole.INPUT_RECORD pkey)
        {

            testrender();

        }

        public void init() {
            Console.Write(string.Concat(Enumerable.Repeat(new string(' ', width) + tab.Newlinechar, height )));
            tab.add("");
            testrender();
        }

        
    }
}
