using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    internal class Tab
    {
        private int width, height, cursorX, cursorY, scrollX, scrollY, selectionstart, selectionoffset;
        private string title;
        private List<string> content;

        public void add(string inputtext) {
            content[cursorY] = content[cursorY].Insert(cursorX, inputtext);
        }

    }
}
