using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea004
{
    internal static class Input
    {
        //workaround for something else that wasnt working
        private static bool writetrue(string conditionfail)
        {
            Console.WriteLine(conditionfail); 
            return true;
        }

        /// <summary>
        /// Ingresa lineas de texto hasta recibir una que es un numero int y que cumple con cierta condidion
        /// </summary>
        /// <param name="prompt">texto impreso inicialmente</param>
        /// <param name="failprompt">texto impreso si se ingresa algo que no es un int</param>
        /// <param name="condition">condicion</param>
        /// <param name="conditionfail">texto impreso si el texto ingresado no cumple con la condicion</param>
        /// <returns>Int que cumple con la condicion</returns>
        public static int IntC(
            string prompt = "Ingrese un numero: ",
            string failprompt = "Eso no es un Numero. Ingrese un numero: ",
            Func<int, bool>? condition = null,
            string conditionfail = "Ese número no es valido. Ingrese un numero: ") 
        {
            condition = condition ?? (x => true); //no se permite poner una funcion anonima como parametro por defecto.
            int ipi;
            do
            {
                ipi = Int(prompt, failprompt);
                // esta linea no me gusta nada. solo imprime el caso de fallo de condicion luegod el primer bucle aprovechando que solo se evalua la segunda parte de un and si la primera es falsa.
            } while (!condition(ipi) && writetrue(conditionfail));
            return ipi;
        }
        /// <summary>
        /// Ingresa lineas de texto hasta recibir una que es un numero int 
        /// </summary>
        /// <param name="prompt">texto impreso inicialmente</param>
        /// <param name="failprompt">texto impreso si se ingresa algo que no es un int</param>
        /// <returns>numero ingresado</returns>
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

        /// <summary>
        /// Ingresa lineas de texto hasta recibir una que es un numero decimal
        /// </summary>
        /// <param name="prompt">texto impreso inicialmente</param>
        /// <param name="failprompt">texto impreso si se ingresa algo que no es un decimal</param>
        /// <returns>numero ingresado</returns>
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
