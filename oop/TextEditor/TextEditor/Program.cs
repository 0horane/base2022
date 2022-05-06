namespace Ej3
{
    class Program
    {

    

        static void Main(string[] args)
        {



            ConsoleKeyInfo pkey;
            do
            {
                //pkey = Console.ReadKey().Key;
                pkey = Console.ReadKey();
                switch (pkey.Key)
                {
                    case ConsoleKey.Enter:
                        currenttab.newline();
                        break
                    case ConsoleKey.Escape:
                        currenttab.esc()
                    case ConsoleKey.Tab:
                        currenttab.add("    ");
                    case ConsoleKey.Backspace:
                        currenttab.rm(-1);
                    case ConsoleKey.Delete:
                        currenttab.rm(-1);
                    case ConsoleKey.RightArrow:
                        currenttab.movecur(1, 0);
                    case ConsoleKey.LeftArrow:
                        currenttab.movecur(-1, 0);
                    case ConsoleKey.UpArrow:
                        currenttab.movecur(0, -1);
                    case ConsoleKey.DownArrow:
                        currenttab.movecur(0, 1);
                    default:
                        currenttab.add(pkey.KeyChar);
                }
                currenttab.render();

            } while (true);
        }
    }
}