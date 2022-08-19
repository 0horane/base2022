using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float inputfloat (string prompt = "Ingrese un numero: ", string failprompt = "Eso no es un Numero. Ingrese un numero: ")
            {
                Console.WriteLine(prompt);
                float inputnumber;
                while (!float.TryParse(Console.ReadLine(), out inputnumber))
                {
                    Console.WriteLine(failprompt);
                }
                return inputnumber;
            }


            string[] months = { "Enero", "Febrero", "Marzo" };
            List<float> parquepatricios = new List<float>();
            List<float> caballito = new List<float>();
            foreach (string month in months)
            {
                parquepatricios.Add(inputfloat($"Ingrese el monto de ventas en {month} para Parque Patricios"));
                caballito.Add(inputfloat($"Ingrese el monto de ventas en {month} para Caballito"));
            }
            
            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine($"El mes de {months[i]} tuvo {(parquepatricios[i] + caballito[i]) / 2} en promedio.");
            }
            float totalparquepatricios = parquepatricios.Sum();
            float totalcaballito = caballito.Sum();

            Console.WriteLine($"El monto total de Parque Patricios es de {totalparquepatricios} ");
            Console.WriteLine($"El monto total de Caballito es de {totalcaballito} ");
            Console.WriteLine($"El monto total es de {totalcaballito+totalparquepatricios} ");
            Console.WriteLine($"El monto promedio es de {(totalcaballito+totalparquepatricios)/2} ");
        }
    }
}
