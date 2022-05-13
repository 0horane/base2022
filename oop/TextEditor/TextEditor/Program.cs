namespace TextEditor
{
    class Program
    {


        static void Main(string[] args)
        {
            Tab onlytab = new Tab(@"C:\Users\Alumno\Desktop\help.txt");
            Window onlywindow = new Window(onlytab, yoffset: Console.GetCursorPosition().Top);
            onlywindow.init();
            ConsoleKeyInfo pkey;
            do
            {
                //pkey = Console.ReadKey().Key;
                pkey = Console.ReadKey();
                onlywindow.testRunCommand(pkey);

            } while (true);
        }
    }
}