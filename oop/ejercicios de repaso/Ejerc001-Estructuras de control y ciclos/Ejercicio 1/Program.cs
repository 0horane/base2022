using System;

namespace Ejerc001_Estructuras_de_control_y_ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa cuantos numeros queres ingresar");
            int howmanynumbers;
            while (!int.TryParse(Console.ReadLine(), out howmanynumbers)) {
                Console.WriteLine("Eso no es un numero entero");
            }
            float accumulator = 0;
            for (int i = 0; i < howmanynumbers; i++)
            {
                Console.WriteLine("Ingresa un numero");
                float inputnumber;
                while (!float.TryParse(Console.ReadLine(), out inputnumber))
                {
                    Console.WriteLine("Eso no es un numero");
                }
                accumulator += inputnumber;
            }

            Console.WriteLine("El promedio es de " + Convert.ToString(accumulator / howmanynumbers));
        }
    }
}
