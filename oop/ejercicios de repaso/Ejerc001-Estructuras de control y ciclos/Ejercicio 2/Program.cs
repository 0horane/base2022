using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el primer numero");
            float number1, number2;
            while (!float.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Eso no es un numero");
            }
            Console.WriteLine("Ingresa el segundo numero");
            while (!float.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Eso no es un numero");
            }
            
            Console.WriteLine(number2 == 0.0 ? "La division por 0 es invalida" : "La division resulta en " + (number1 / number2));

        }
    }
}
