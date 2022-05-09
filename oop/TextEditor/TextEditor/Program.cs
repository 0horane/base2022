namespace TextEditor
{
    class Program
    {

    

        static void Main(string[] args)
        {

            Tab currenttab = new Tab(); 

            ConsoleKeyInfo pkey;
            do
            {
                //pkey = Console.ReadKey().Key;
                pkey = Console.ReadKey();
                switch (pkey.Key)
                {
                    case ConsoleKey.Enter:
                        currenttab.add("\n");
                        break;
                    case ConsoleKey.Escape:
                        currenttab.esc();
                        break;
                    case ConsoleKey.Tab:
                        currenttab.add("    ");
                        break;
                    case ConsoleKey.Backspace:
                        currenttab.rm(-1);
                        break;
                    case ConsoleKey.Delete:
                        currenttab.rm(1);
                        break;
                    case ConsoleKey.RightArrow:
                        currenttab.movecurX(1);
                        break;
                    case ConsoleKey.LeftArrow:
                        currenttab.movecurX(-1);
                        break;
                    case ConsoleKey.UpArrow:
                        currenttab.movecurY(-1);
                        break;
                    case ConsoleKey.DownArrow:
                        currenttab.movecurY(1);
                        break;
                    default:
                        currenttab.add(pkey.KeyChar.ToString());
                        break;
                }
                currenttab.testrender();

            } while (true);
        }
    }
}