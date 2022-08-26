using System;

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
            float number1 = inputfloat("Ingresa el primer numero");
            float number2 = inputfloat("Ingresa el segundo numero");
            
            Console.WriteLine("La suma resulta en " + (number1 + number2));
            Console.WriteLine("La diferencia resulta en " + (number1 - number2));
            Console.WriteLine("El producto resulta en " + (number1 * number2));
            Console.WriteLine(number2 == 0.0 ? "La division por 0 es invalida" : "La division resulta en " + (number1 / number2));

        }
    }
}
