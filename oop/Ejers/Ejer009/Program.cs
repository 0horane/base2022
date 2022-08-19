using System;

namespace Ejer009
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(calc.factorial(Ulong(condition: x => x > 0)));



        }

        public static class calc
        {
            public static ulong factorial(ulong num)
            {

                return num == 1 ? num : factorial(num - 1) * num ;
            }
        }
        public static ulong Ulong(
            string prompt = "Ingrese un numero: ",
            string failprompt = "Eso no es un Numero. Ingrese un numero: ",
            Func<ulong, bool>? condition = null,
            string conditionfail = "Ese número no es valido. Ingrese un numero: ")
        {
            condition = condition ?? (x => true); //no se permite poner una funcion anonima como parametro por defecto.

            ulong ipi;
            Console.WriteLine(prompt);

            while (true)
            {
                while (!ulong.TryParse(Console.ReadLine(), out ipi))
                    Console.WriteLine(failprompt);
                if (condition(ipi))
                    break;
                Console.WriteLine(conditionfail);
            };
            return ipi;
        }

    }
}

    

