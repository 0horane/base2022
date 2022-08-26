using System;
using System.Collections.Generic;
using System.Globalization;
//using System.Linq;
namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            float inputfloat(string prompt = "Ingrese un numero: ", string failprompt = "Eso no es un Numero. Ingrese un numero: ")
            {
                Console.WriteLine(prompt);
                float inputnumber;
                while (!float.TryParse(Console.ReadLine(), out inputnumber))
                {
                    Console.WriteLine(failprompt);
                }
                return inputnumber;
            }

            int inputint(string prompt = "Ingrese un numero: ", string failprompt = "Eso no es un Numero. Ingrese un numero: ")
            {
                Console.WriteLine(prompt);
                int inputnumber;
                while (!int.TryParse(Console.ReadLine(), out inputnumber))
                {
                    Console.WriteLine(failprompt);
                }
                return inputnumber;
            }

            string inputstr(string prompt = "Ingrese un string: ", string failprompt = "Eso no es un string. Ingrese un numero: ")
            {
                Console.WriteLine(prompt);
                return Console.ReadLine() ;
            }



            int numdocentes = inputint("Cuantos docentes quiere ingresar?");
            List<string> nombres = new List<string>();
            List<float> brutos = new List<float>();
            List<float> jubilaciones = new List<float>();
            List<float> obrasociales = new List<float>();
            for (int i = 0; i < numdocentes; i++)
            {
                nombres.Add(inputstr("Ingresa el nombre del docente"));
                brutos.Add(inputfloat("Ingresa el salario bruto del docente"));
                jubilaciones.Add(inputfloat("Ingresa el aporte de jubilaciones del docente (de 0 a 1)"));
                obrasociales.Add(inputfloat("Ingresa el aporte de obra social del docente (de 0 a 1)"));

                for (int j = 0; j < nombres.Count; j++)
                {
                    Console.WriteLine($"Nombre completo: {nombres[j]}");
                    Console.WriteLine($"Salario bruto: {brutos[j]}");
                    Console.WriteLine($"Aporte de jubilaciones: {jubilaciones[j]}");
                    Console.WriteLine($"Aporte de obra social: {obrasociales[j]}");
                    Console.WriteLine($"Salario neto: {brutos[j] * (1 - jubilaciones[j]) * (1 - obrasociales[j])}");
                    Console.WriteLine("");
                }
            }


            

        }
    }
}
