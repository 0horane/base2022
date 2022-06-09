using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea004
{
    internal static class Input
    {
        private static bool writetrue(string conditionfail)
        {
            Console.WriteLine(conditionfail); 
            return true;
        }
        public static int IntC(
            string prompt = "Ingrese un numero: ",
            string failprompt = "Eso no es un Numero. Ingrese un numero: ",
            Func<int, bool>? condition = null,
            string conditionfail = "Ese número no es valido. Ingrese un numero: ") 
        {
            condition = condition ?? (x => true);
            int ipi;
            do
            {
                ipi = Int(prompt, failprompt);
            } while (!condition(ipi) && writetrue(conditionfail));
            return ipi;
        }
        public static int Int(
            string prompt = "Ingrese un numero: ", 
            string failprompt = "Eso no es un Numero. Ingrese un numero: ")
        {
            
            Console.WriteLine(prompt);
            int inputnumber;
            while (!int.TryParse(Console.ReadLine(), out inputnumber))
                Console.WriteLine(failprompt);
            return inputnumber;
        }
        public static decimal Decimal(
            string prompt = "Ingrese un numero: ",
            string failprompt = "Eso no es un Numero. Ingrese un numero: ")
        {

            Console.WriteLine(prompt);
            decimal inputnumber;
            while (!decimal.TryParse(Console.ReadLine(), out inputnumber))
                Console.WriteLine(failprompt);
            return inputnumber;
        }
    }
}
