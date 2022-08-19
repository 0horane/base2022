using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    public class WindowManager
    {
        private List<sqWindow> windows;
        private List<Tab> lostTabs;
        private uint activeTab = 0;

        internal WindowManager(List<sqWindow>? windows, List<Tab>? lostTabs)
        {
            this.windows = windows ?? new List<sqWindow> { new sqWindow() };
            this.lostTabs = lostTabs ?? new List<Tab>();
        }

        public void delegateMouseInput(short x, short y ) { }


    }
}
