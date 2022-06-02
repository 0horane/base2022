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


        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/attributes/how-to-create-a-c-cpp-union-by-using-attributes
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
            /*
            public (uint X, uint Y) dwMousePosition;
            public ushort dwButtonState;
            public ushort dwEventFlags;

            public (uint X, uint Y) dwSize;
            public bool dwSizebSetFocus;
            */
        }

        private static IntPtr stdOut;
        private static IntPtr stdIn;

        static AConsole()
        {
            //if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))

            stdOut = GetStdHandle(-11); //-11=stdout
            stdIn = GetStdHandle(-10); //-10=stdin

            GetConsoleMode(stdOut, out var outConsoleMode);
            //4=ENABLE_VIRTUAL_TERMINAL_PROCESSING 
            //16=ENABLE_MOUSE_INPUT 128=ENABLE_EXTENDED_FLAGS  64=ENABLE_QUICK_EDIT_MODE 
            // !(!p || q) inverted material conditional
            SetConsoleMode(stdOut,  outConsoleMode | 4 );
            SetConsoleMode(stdIn, ~(~(outConsoleMode | 128 | 16) | 64));


            //Environment.GetEnvironmentVariable("NO_COLOR")

        }

        public static void WriteLine(string istr)
        {
            Console.WriteLine(istr);
        }
        public static void Write(string istr)
        {
            Console.Write(istr);
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
                    GetConsoleMode(stdOut, out var outConsoleMode);

                    switch (record.EventType)
                    {
                        case 0:
                            break;
                        case 1:
                            Write("key");
                            break;
                        case 2:
                            Write("Mouse");
                            //WriteLine($" dwMousePosition: {record.dwMousePosition}, dwButtonState: {record.dwButtonState}, dwControlKeyState: {record.dwControlKeyState}, dwEventFlags: {record.dwEventFlags}");
                            break;
                        case 4:
                            Write("Window");
                            ///WriteLine($" X: {record.dwSize.X}, Y: {record.dwSize.Y}");
                            break;
                        case 16:
                            Write("focus");
                            //WriteLine($" docus: {record.dwSizebSetFocus}");
                            break;

                        default:
                            Write("OTHER");
                            break;
                    }
                    if (record.EventType != 0) {
                        WriteLine($" bKeyDown: {record.bKeyDown}, wRepeatCount: {record.wRepeatCount}, wVirtualKeyCode: {record.wVirtualKeyCode}, wVirtualScanCode: {record.wVirtualScanCode}, UnicodeChar: {record.UnicodeChar},  dwControlKeyState: {record.dwControlKeyState},");

                    }
                }
            } else
            {
                WriteLine("noinput");
            }
            
        }


    }
}

