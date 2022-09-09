namespace TextEditor
{
    class Program
    {


        static void Main(string[] args)
        {
            /*
            Tab onlytab = new Tab(@"C:\Users\Alumno\Desktop\help.txt");
            sqWindow onlywindow = new sqWindow(onlytab);
            onlywindow.init();
            ConsoleKeyInfo pkey;
            do
            {
                pkey = Console.ReadKey();
                onlywindow.testRunCommand(pkey);

            } while (true);

            do
            {
                pkey = Console.ReadKey();
                onlywindow.testRunCommand(pkey);

            } while (true);
            /*/
            while (true) {
                AConsole.INPUT_RECORD[]  inputs= AConsole.ReadInputs(128);

                foreach (AConsole.INPUT_RECORD record in inputs)
                {
                    switch (record.EventType)
                    {
                        case 0:
                            break;
                        case 1:
                            AConsole.WriteLine($"key  down:{record.Event.KeyEvent.bKeyDown} rep:{record.Event.KeyEvent.wRepeatCount} vsc:{record.Event.KeyEvent.wVirtualScanCode} vkc:{record.Event.KeyEvent.wVirtualKeyCode} char:{record.Event.KeyEvent.uChar} /   cks:{record.Event.KeyEvent.dwControlKeyState}");
                            break;
                        case 2:
                            AConsole.WriteLine($"Mouse state:{record.Event.MouseEvent.dwButtonState} cks:{record.Event.MouseEvent.dwControlKeyState} flags:{record.Event.MouseEvent.dwEventFlags} x:{record.Event.MouseEvent.dwMousePosition.c.X} y:{record.Event.MouseEvent.dwMousePosition.c.Y}");
                            break;
                        case 4:
                            AConsole.WriteLine($"Window x:{record.Event.WindowBufferSizeEvent.dwSize.c.X} y:{record.Event.WindowBufferSizeEvent.dwSize.c.Y}");
                            break;
                        case 16:
                            AConsole.WriteLine($"focus {record.Event.FocusEvent.bSetFocus.i}");
                            break;
                        default:
                            AConsole.WriteLine($"on goddd  {record.EventType}");
                            break;
                    }

                }
            }
            //*/
        }
    }
}