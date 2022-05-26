using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace TextEditor
{
    public static class Printer
    {
        [DllImport("kernel32.dll")]
        private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        private static extern bool ReadConsoleInput(IntPtr hConsoleInput, out PINPUT_RECORD lpBuffer, int  nLength, out int lpNumberOfEventsRead);

        //https://github.com/SiTox/07-SK-K-PM/blob/master/PacMan/KeyPressed.cs
        static Printer()
        {
            

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var consoleHandle = GetStdHandle(-11); //-11=stdout

                GetConsoleMode(consoleHandle, out var outConsoleMode);
                SetConsoleMode(consoleHandle, outConsoleMode | 4); //4=ENABLE_VIRTUAL_TERMINAL_PROCESSING
            }



            //Environment.GetEnvironmentVariable("NO_COLOR")
            
        }
    }
}
