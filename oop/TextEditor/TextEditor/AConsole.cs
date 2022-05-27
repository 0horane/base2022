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
    public static class AConsole
    {
        [DllImport("kernel32.dll")]
        private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        private static extern bool ReadConsoleInput(IntPtr hConsoleInput, [Out] INPUT_RECORD[] lpBuffer, int  nLength, out int lpNumberOfEventsRead);

        //https://github.com/SiTox/07-SK-K-PM/blob/master/PacMan/KeyPressed.cs
        [StructLayout(LayoutKind.Sequential)]
        private struct INPUT_RECORD
        {
            public ushort EventType;
            public uint bKeyDown;
            public ushort wRepeatCount;
            public ushort wVirtualKeyCode;
            public ushort wVirtualScanCode;
            public char UnicodeChar;
            public uint dwControlKeyState;
        }

        private static IntPtr stdOut;
        private static IntPtr stdIn;

        static AConsole()
        {
            //if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            
            stdOut = GetStdHandle(-11); //-11=stdout
            stdIn = GetStdHandle(-10); //-10=stdin

            GetConsoleMode(stdOut, out var outConsoleMode);
            SetConsoleMode(stdOut, outConsoleMode | 4); //4=ENABLE_VIRTUAL_TERMINAL_PROCESSING
            

            //Environment.GetEnvironmentVariable("NO_COLOR")
            
        }

        public static void WriteLine(string istr)
        {
            Console.WriteLine(istr);
        }

        

        public static void ReadKey()
        {
            // https://stackoverflow.com/questions/46795072/how-to-get-mouse-input-inside-a-c-console-program-on-windows-10 TODO MOUSE INPUT
            WriteLine("\u001b[34;45;9m\nsegjkhlsfjklgjkdfhskjsdglkuhdfskldgkhdfghuksdkulbsnilbhgvhblj,gsb\u001b[0m");
            int nRead = 0;
            INPUT_RECORD[] iRecord = new INPUT_RECORD[128];
            if (ReadConsoleInput(stdIn, iRecord, 128, out nRead))
            {
                foreach (INPUT_RECORD record in iRecord)
                {
                    if (record.EventType != 0) { 
                    WriteLine($"EventType:{record.EventType}, bKeyDown: {record.bKeyDown}, wRepeatCount: {record.wRepeatCount}, wVirtualKeyCode: {record.wVirtualKeyCode}, wVirtualScanCode: {record.wVirtualScanCode}, UnicodeChar: {record.UnicodeChar},  dwControlKeyState: {record.dwControlKeyState},");
                    }
                }
            } else
            {
                WriteLine("noinput");
            }
            
        }


    }
}

