using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    internal class Window
    {

        private int width, height, xoffset, yoffset, scrollY, lastwrappedlines = 0, skippedlines=4;
        private Tab tab;
        public Window(Tab? tab = null, int ? width = null, int? height = null, int xoffset = 0, int yoffset = 0, int scrollY=0)
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
            scrollY =  Math.Max(0, tab.getCursorY() - height / 3 * 2);
            //gets necesary data to print
            string[] content = tab.getContent().ToArray();
            int cursorX = tab.getCursorX();
            int cursorY = tab.getCursorY();
            //starts printing title at top
            Console.SetCursorPosition(0, yoffset);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(tab.getTitle() + new string(' ', width - tab.getTitle().Length));
            Console.ResetColor();
            //function has to be declared locally because no params (dumb way of doing things but ok)
            string statusLine()
            {
                return $"char {cursorX}/{content[cursorY].Length - 1}, row {cursorY}/{content.Length - 1}   on:\"{((tab.getCharAt() == tab.getNewlinechar()) ? "\\n" : tab.getCharAt())}\"  scroll {yoffset}  window {width}/{height}";
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
                    outputext += localsubstring + tab.getNewlinechar();
                    linessofar++;
                    if (j<cursorY || (j == cursorY && cursorX > i+width-1 ))
                        cpos++;
                    
                    
                }
                if (content[j].Length == 0)
                {
                    outputext += new string(' ', width) + tab.getNewlinechar();
                    linessofar++;
                    if (j < cursorY)
                        cpos++;
                    

                }


            }
            if(height - linessofar - skippedlines > 0)
            {
                string newlines = string.Concat(Enumerable.Repeat(new string(' ', width) + tab.getNewlinechar(), height - linessofar - skippedlines));
                outputext += newlines.Substring(0,newlines.Length-1);

            }

            lastwrappedlines = cpos - linessofar;
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
                    tab.add(tab.getNewlinechar());
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

        public void init() {
            Console.Write(string.Concat(Enumerable.Repeat(new string(' ', width) + tab.getNewlinechar(), height )));
            tab.add("");
            testrender();
        }

        
    }
}
