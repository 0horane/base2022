using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    internal class Tab
    {


        private int cursorX, cursorY, selectionoffset;
        private string title, newlinechar;
        private List<string> content;
        private int debugvar;



        public Tab(string? title = null, string content = "", int cursorX = 0, int cursorY = 0,  int selectionoffset = 0, string? newlinechar = null )
        {
            this.cursorX = cursorX;
            this.cursorY = cursorY;
            this.selectionoffset = selectionoffset;
            this.newlinechar = newlinechar ?? Environment.NewLine;

            if (title != null && File.Exists(title))
            {
                this.content = File.ReadAllText(title).Split(newlinechar).ToList<string>();
            } else
            {
                this.content = content.Split(newlinechar).ToList<string>();
            }
            this.title = title ?? "New Text Document";

        }



        /// <summary>
        /// adds text after current character, replacing any selection
        /// </summary>
        /// <param name="inputtext"></param>
        public void add(string inputtext) {
            rm(0);
            content[cursorY] = content[cursorY].Insert(cursorX, inputtext);
            splitlines(cursorY);
            movecurX(inputtext.Length-selectionoffset);
            debugvar = inputtext.Length - selectionoffset;
            selectionoffset = 0;
        }

        /// <summary>
        /// removes rmoffset chars in whichever direction is indicated, or selection.
        /// </summary>
        /// <param name="rmoffset"></param>
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

        /// <summary>
        /// moves cursor x characters on a line. moves over newlines.
        /// </summary>
        /// <param name="x"></param>
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

        /// <summary>
        /// moves cursor up or down. does not adjust cursor X
        /// </summary>
        /// <param name="y"></param>
        public void movecurY(int y)
        {
            if (0 <= cursorY+y && cursorY+y <= content.Count-1) { 
                cursorY+=y;
            }
        }

        /// <summary>
        /// deletes any selection.
        /// </summary>
        public void esc() {
            selectionoffset = 0;
            adjustcursor();
        }

        /// <summary>
        /// UNIMPLEMENTED returns the amount of characters until the beginning of the amount'th word. 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int word(int amount = 1)
        {

            return 0;
        }

        /// <summary>
        /// run to replace \ns with actual newlines
        /// </summary>
        /// <param name="linenumber"></param>
        private void splitlines(int linenumber)
        {
            if (content[linenumber].Contains(newlinechar))
            {
                string[] addedlines = content[linenumber].Split(newlinechar);
                content.RemoveAt(linenumber);
                for (int i = 0; i < addedlines.Length; i++)
                {
                    content.Insert(linenumber + i, addedlines[i]);
                }
               
            } 
        }

        /// <summary>
        /// adjusts cursosr location, if its too far to the right
        /// </summary>
        private void adjustcursor()
        {
            if (cursorX > content[cursorY].Length)
            {
                cursorX = content[cursorY].Length;
            }
        }

        public void write(string? path = null) {
            File.WriteAllText(path ?? title, getString());
        }

        /*************************************GET AND SET******************************************/

        public int getCursorX() { 
            return cursorX;
        }

        public int getCursorY()
        {
            return cursorY;
        }

        public List<string> getContent()
        {
            return content;
        }

        public string getString()
        {
            return String.Join(newlinechar , content);
        }

        public string getTitle()
        {
            return title;
        }


        public string getNewlinechar()
        {
            return newlinechar;
        }
    }
}
