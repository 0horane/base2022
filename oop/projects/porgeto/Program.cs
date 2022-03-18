using System;

namespace porgeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Accumulator suma = new Accumulator((x, y) => x + y, x => x + 1, 0);
            Accumulator factorial = new Accumulator((x, y) => x * y, x => x + 1, 1);

            Console.WriteLine(factorial.accumulate(1, 10));
        }


    }
}
