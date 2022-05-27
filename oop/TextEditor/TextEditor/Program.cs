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
            */
            while (true) { 
            AConsole.ReadKey();
            }
            //AConsole.WriteLine("\u001b[34;45;9mtest");
        }
    }
}