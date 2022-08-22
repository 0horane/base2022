using System;

namespace Ej1t2
{
    internal class Program
    {
        /// <summary>
        /// Prompts the user for a valid double until inputted correctly
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="failprompt"></param>
        /// <returns>Input Double</returns>
        static double Inputdouble(string prompt = "Ingrese un numero: ", string failprompt = "Eso no es un Numero. Ingrese un numero: ")
        {
            Console.WriteLine(prompt);
            double inputnumber;
            while (!double.TryParse(Console.ReadLine(), out inputnumber))
            {
                Console.WriteLine(failprompt);
            }
            return inputnumber;
        }

        /// <summary>
        /// Prompts the user for a valid string until inputted correctly
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="failprompt"></param>
        /// <returns>Input String</returns>
        static string Inputstr(string prompt = "Ingrese un texto: ", string failprompt = "Eso no es un texto. Ingrese un texto: ")
        {
            Console.WriteLine(prompt);
            string ?inputstring = Console.ReadLine();
            while (inputstring==null) 
            {
                Console.WriteLine(failprompt);
                inputstring = Console.ReadLine();
            }
            return inputstring;
        }
        static void Main(string[] args)
        {
            string name = Inputstr("Ingrese el nombre: ");
            string lastname = Inputstr("Ingrese el apellido: ");
            double hoursworked = Inputdouble("Ingrese las horas trabajadas: ");
            double hourlywage = Inputdouble("Ingrese el valor hora: ");

            Console.WriteLine(hoursworked * hourlywage);
        }
    }
}