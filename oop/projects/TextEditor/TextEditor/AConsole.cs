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
        //https://github.com/Yostage/ccd/blob/master/ccd2/SuperConsole.cs
        //Data structure for inputs
        [StructLayout(LayoutKind.Sequential)]
        public struct INPUT_RECORD
        {
            public ushort EventType;
            public EVENT_RECORD Event;

        }


        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct KEY_EVENT_RECORD
        {
            [FieldOffset(0), MarshalAs(UnmanagedType.Bool)]
            public bool bKeyDown;
            [FieldOffset(4), MarshalAs(UnmanagedType.U2)]
            public ushort wRepeatCount;
            [FieldOffset(6), MarshalAs(UnmanagedType.U2)]
            public ushort wVirtualKeyCode;
            [FieldOffset(8), MarshalAs(UnmanagedType.U2)]
            public ushort wVirtualScanCode;
            [FieldOffset(10)]
            public char uChar;
            [FieldOffset(12), MarshalAs(UnmanagedType.U4)]
            public uint dwControlKeyState;


        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSE_EVENT_RECORD
        {
            public uint_coord dwMousePosition;
            public ushort dwButtonState;
            public ushort dwControlKeyState;
            public ushort dwEventFlags;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOW_BUFFER_SIZE_RECORD
        {
            public uint_coord dwSize;
        }
        public struct MENU_EVENT_RECORD
        {
            public uint_coord dwCommandId;
        }
        public struct FOCUS_EVENT_RECORD
        {
            public uint_coord bSetFocus;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct COORD
        {
            public short X;
            public short Y;
        }

        //So for some reason if i dont have this the next parameter ends up
        //being a 0. and if i add a padding parameter it gets filled in the
        //next's stead. so this ridiculous workaround will do for now
        [StructLayout(LayoutKind.Explicit)]
        public struct uint_coord
        {
            [FieldOffset(0)]
            public uint i;
            [FieldOffset(0)]
            public COORD c;
        }



        [StructLayout(LayoutKind.Explicit)]
        public struct uChar
        {
            [FieldOffset(0)]
            public char UnicodeChar;
            [FieldOffset(0)]
            public char AsciiChar;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct EVENT_RECORD
        {
            [FieldOffset(0)]
            public KEY_EVENT_RECORD KeyEvent;
            [FieldOffset(0)]
            public MOUSE_EVENT_RECORD MouseEvent;
            [FieldOffset(0)]
            public WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;
            [FieldOffset(0)]
            public MENU_EVENT_RECORD MenuEvent;
            [FieldOffset(0)]
            public FOCUS_EVENT_RECORD FocusEvent;
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
        //https://stackoverflow.com/questions/5272177/console-writeline-slow
        {
            Console.Write(istr);
        }



        public static INPUT_RECORD[] ReadInputs(uint howmany)
        {
            //Console.SetCursorPosition(0, 0);
            //WriteLine("\u001b[34;45;9m\nsegjkhlsfjklgjkdfhskjsdglkuhdfskldgkhdfghuksdkulbsnilbhgvhblj,gsb\u001b[0m");
            int nRead = 0;
            INPUT_RECORD[] iRecord = new INPUT_RECORD[howmany];
            if (ReadConsoleInput(stdIn, iRecord, (int)howmany, out nRead))
            {
                return iRecord;
                {
                    /*
                    
                    */
                }

            } else
            {
                return iRecord;
            }

        }
    }
}

