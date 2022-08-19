namespace Examen_1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] diaspormes = {31,28,31,30,31,30,31,31,30,31,30,31 };
            string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            //pide que se ingrese un numero entero hasta que sea valido
            int inputmonth;
            do
                Console.WriteLine("Ingrese un numero");
            while (!Int32.TryParse(Console.ReadLine(), out inputmonth));

            Console.WriteLine("Has ingresado el mes {0} el cual tiene {1} dias.", meses[inputmonth-1], diaspormes[inputmonth - 1]);

        }
    }
}