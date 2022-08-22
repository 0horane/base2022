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

            Console.WriteLine("Cuantos meses vas a ingresar?");
            float number1;
            while (!float.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Eso no es un numero");
            }

            string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"  };
            List<float> parquepatricios = new List<float>();
            List<float> caballito = new List<float>();
            for (int i = 0, i2 = 0; i < number1; i++, i2= i2==11 ? 0 : i2+1)
            {

                parquepatricios.Add(inputfloat($"Ingrese el monto de ventas en {months[i2]} para Parque Patricios"));
                caballito.Add(inputfloat($"Ingrese el monto de ventas en {months[i2]} para Caballito"));
            }
            
            for (int i = 0, i2 = 0; i < number1; i++, i2 = i2 == 11 ? 0 : i2 + 1)
            {
                Console.WriteLine($"El mes de {months[i2]} tuvo {(parquepatricios[i] + caballito[i]) / 2} en promedio.");
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
