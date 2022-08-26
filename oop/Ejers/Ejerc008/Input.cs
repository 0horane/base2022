using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Reflection;

namespace Ejer008
{
    internal static class Input
    {
        /// <summary>
        /// Ingresa lineas de texto hasta recibir una que es un numero int y que cumple con cierta condidion
        /// </summary>
        /// <param name="prompt">texto impreso inicialmente</param>
        /// <param name="failprompt">texto impreso si se ingresa algo que no es un int</param>
        /// <param name="condition">condicion</param>
        /// <param name="conditionfail">texto impreso si el texto ingresado no cumple con la condicion</param>
        /// <returns>Int que cumple con la condicion</returns>
        public static int Int(
            string prompt = "Ingrese un numero: ",
            string failprompt = "Eso no es un Numero. Ingrese un numero: ",
            Func<int, bool>? condition = null,
            string conditionfail = "Ese número no es valido. Ingrese un numero: ")
        {
            condition = condition ?? (x => true); //no se permite poner una funcion anonima como parametro por defecto.

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

        /*
         intente hacer un tryparse univeresal pero no me salio
            T Number<T>(
            Type? type = null,
            type = type ?? typeof(T);
            Type[] paramTypes = new Type[] { typeof(string), Type.GetType("System.Int32").MakeByRefType() };
            MethodInfo method = type.GetMethod("TryParse", paramTypes);
            Type objectType = Assembly.GetAssembly(type).GetType(typeName);
         */

        /// <summary>
        /// Ingresa lineas de texto hasta recibir una que es un numero decimal
        /// </summary>
        /// <param name="prompt">texto impreso inicialmente</param>
        /// <param name="failprompt">texto impreso si se ingresa algo que no es un decimal</param>
        /// <returns>numero ingresado</returns>
        public static float Float(
            string prompt = "Ingrese un numero: ",
            string failprompt = "Eso no es un Numero. Ingrese un numero: ",
            Func<float, bool>? condition = null,
            string conditionfail = "Ese número no es valido. Ingrese un numero: ")
        {
            condition = condition ?? (x => true); //no se permite poner una funcion anonima como parametro por defecto.

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
            condition = condition ?? (x => true); //no se permite poner una funcion anonima como parametro por defecto.

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
