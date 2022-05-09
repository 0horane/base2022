using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    internal class Tab
    {
        private int width, height, cursorX, cursorY, scrollX, scrollY, selectionoffset;
        private string title;
        private List<string> content;
        private int debugvar;

        public Tab(string content = "", string title = "New Text Document", int? width = null, int? height = null, int cursorX = 0, int cursorY = 0, int scrollX = 0, int scrollY = 0, int selectionoffset = 0 )
        {
            this.width = width ?? Console.WindowWidth;
            this.height = height ?? Console.WindowHeight;
            this.cursorX = cursorX;
            this.cursorY = cursorY;
            this.scrollX = scrollX;
            this.scrollY = scrollY;
            this.selectionoffset = selectionoffset;
            this.title = title;
            this.content = content.Split("\n").ToList<string>();
        }

        public void testrender() {
            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(title);
            Console.ResetColor();


            string outputext = "";
            int linessofar, j;
            for (linessofar = 0, j = 0; linessofar < height - 2 && j < content.Count; j++)
            {
                for (var i = 0; i < content[j].Length && linessofar < height - 2; i += width - 1) {
                    //if (j == cursorY && i <= cursorX && cursorX < i+ width)
                    string localsubstring = content[j].Substring(i, Math.Min(width - 1, content[j].Length - i));
                    localsubstring += new string(' ', width - localsubstring.Length);
                    outputext += localsubstring+"\n";
                    linessofar++;
                }
                if (content[j].Length == 0)
                {
                    outputext += new string(' ', width)+ "\n";
                    linessofar++;
                }

                
            }
            outputext+= string.Concat(Enumerable.Repeat(new string(' ', width) + '\n', height - linessofar-4)); 
            
            Console.Write(outputext + '\n');
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(statusLine());
            Console.ResetColor();
            Console.SetCursorPosition((cursorX % width)+ cursorX / width, cursorY-scrollY+1+cursorX/width);


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

        private string statusLine() {
            return $"char {cursorX}/{content[cursorY].Length - 1}, row {cursorY}/{content.Count - 1}";
        }

        public void add(string inputtext) {
            rm(0);
            content[cursorY] = content[cursorY].Insert(cursorX, inputtext);
            splitlines(cursorY);
            movecurX(inputtext.Length-selectionoffset);
            debugvar = inputtext.Length - selectionoffset;
            selectionoffset = 0;
        }

        public void rm(int rmoffset)
        {
            adjustcursor();
            if ((cursorY == content.Count - 1 && cursorX + rmoffset > content[cursorY].Length) || (cursorY == 0 && rmoffset+cursorX<0) )
            {
                return;
            }
            int usedoffset = selectionoffset != 0 ? selectionoffset : rmoffset;
            if (usedoffset < 0)
            {
                movecurX(usedoffset);
            }
            usedoffset = Math.Abs(usedoffset);
            while (usedoffset > content[cursorY].Length - cursorX){
                
                content[cursorY] += content[cursorY + 1];
                content.RemoveAt(cursorY + 1);
                usedoffset -= 1;

            }
            content[cursorY] = content[cursorY].Remove(cursorX, usedoffset);
            
        }

        public void movecurX(int x) {
            adjustcursor();
            cursorX += x;
            while (0 > cursorX ) {
                if (cursorY != 0)
                {
                    cursorY--;
                    cursorX = content[cursorY].Length;
                    

                } else
                {
                    cursorX = 0;
                }
            }
            while ( cursorX > content[cursorY].Length ) //this could be a division if i wanted to do things more effciiently
            {
                if (cursorY != content.Count - 1)
                {
                    cursorX = 0;
                    cursorY++;
                    

                }
                else {
                    cursorX = content[cursorY].Length;
                } 

                
            }
            
        }


        public void movecurY(int y)
        {
            if (0 <= cursorY+y && cursorY+y <= content.Count-1) { 
                cursorY+=y;
            }
        }

        public void esc() {
            selectionoffset = 0;
        }

        private void splitlines(int linenumber)
        {
            if (content[linenumber].Contains("\n"))
            {
                string[] addedlines = content[linenumber].Split("\n");
                content.RemoveAt(linenumber);
                for (int i = 0; i < addedlines.Length; i++)
                {
                    content.Insert(linenumber + i, addedlines[i]);
                }
               
            } 
        }

        private void adjustcursor()
        {
            if (cursorX > content[cursorY].Length)
            {
                cursorX = content[cursorY].Length;
            }
        }


    }
}
