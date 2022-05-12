namespace TextEditor
{
    class Program
    {


        static void Main(string[] args)
        {
            Tab onlytab = new Tab(@"C:\Users\Alumno\Desktop\help.txt");
            Window onlywindow = new Window(onlytab); 
            onlywindow.testrender();
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