using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    internal class Window
    {

        private int width, height, xoffset, yoffset;
        private Tab tab;
        public Window(Tab? tab = null, int ? width = null, int? height = null, int xoffset = 0, int yoffset = 0)
        {
            this.width = width ?? Console.WindowWidth;
            this.height = height ?? Console.WindowHeight;
            this.xoffset = xoffset;
            this.yoffset = yoffset;
            this.tab = tab ?? new Tab();
        }

        public void testrender()
        {
            string[] content = tab.getContent().ToArray();
            int cursorX = tab.getCursorX();
            int cursorY = tab.getCursorY();
            //Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(tab.getTitle());
            Console.ResetColor();

            string statusLine()
            {
                return $"char {cursorX}/{content[cursorY].Length - 1}, row {cursorY}/{content.Length - 1}";
            }

            string outputext = "";
            int linessofar, j;
            for (linessofar = 0, j = 0; linessofar < height - 2 && j < content.Length; j++)
            {
                for (var i = 0; i < content[j].Length && linessofar < height - 2; i += width - 1)
                {
                    //if (j == cursorY && i <= cursorX && cursorX < i+ width)
                    string localsubstring = content[j].Substring(i, Math.Min(width - 1, content[j].Length - i));
                    localsubstring += new string(' ', width - localsubstring.Length);
                    outputext += localsubstring + "\n";
                    linessofar++;
                }
                if (content[j].Length == 0)
                {
                    outputext += new string(' ', width) + "\n";
                    linessofar++;
                }


            }
            outputext += string.Concat(Enumerable.Repeat(new string(' ', width) + '\n', height - linessofar - 4));

            Console.Write(outputext + '\n');
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(statusLine());
            Console.ResetColor();
            //Console.SetCursorPosition((cursorX % width) + cursorX / width, cursorY - tab.getScrollY() + 1 + cursorX / width);


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
                    {
                        tab.write();
                    } else
                    {
                        tab.add(pkey.KeyChar.ToString());
                    }
                    break;
                case ConsoleKey.Enter:
                    tab.add("\n");
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
                    tab.movecurX(1);
                    break;
                case ConsoleKey.LeftArrow:
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

        
    }
}
