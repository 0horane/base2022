namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int accumulator4 = 0 , accumulatorshown = 0;
            
            for (int i = 1; i <= 20; i++)
            {
                if (i % 4 == 0)
                {
                    accumulator4 += i;

                }
                else {
                    Console.WriteLine(i);
                    accumulatorshown += i;    
                }
            }

            Console.WriteLine($"La suma de todos los valores es de {accumulator4+accumulatorshown}");
            Console.WriteLine($"La suma de los multiplos de4 es de {accumulator4}");
            Console.WriteLine($"La suma de los numeros mostrados es de {accumulatorshown}");

        }
    }
}


