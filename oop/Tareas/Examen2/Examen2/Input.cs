using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Examen2
{
    internal static class Input
    {

        public static int Int(
            string prompt = "Ingrese un numero: ",
            string failprompt = "Eso no es un Numero. Ingrese un numero: ",
            Func<int, bool>? condition = null,
            string conditionfail = "Ese número no es valido. Ingrese un numero: ")
        {
            condition = condition ?? (x => true);

            int ipi;
            Console.WriteLine(prompt);

            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out ipi))
                    Console.WriteLine(failprompt);
                if (condition(ipi))
                    break;
                Console.WriteLine(conditionfail);
            };
            return ipi;
        }

        public static float Float(
            string prompt = "Ingrese un numero: ",
            string failprompt = "Eso no es un Numero. Ingrese un numero: ",
            Func<float, bool>? condition = null,
            string conditionfail = "Ese número no es valido. Ingrese un numero: ")
        {
            condition = condition ?? (x => true); 

            float ipi;
            Console.WriteLine(prompt);

            while (true)
            {
                while (!float.TryParse(Console.ReadLine(), out ipi))
                    Console.WriteLine(failprompt);
                if (condition(ipi))
                    break;
                Console.WriteLine(conditionfail);
            };
            return ipi;
        }

        public static string String(
            string prompt = "Ingrese un string: ",
            Func<string, bool>? condition = null,
            string conditionfail = "Ese strimg no es valido. Ingrese un strimg: ")
        {
            condition = condition ?? (x => true); 

            string ipi;
            Console.WriteLine(prompt);

            while (true)
            {
                ipi = Console.ReadLine();
                if (condition(ipi))
                    break;
                Console.WriteLine(conditionfail);
            };
            return ipi;
        }


    }
}
