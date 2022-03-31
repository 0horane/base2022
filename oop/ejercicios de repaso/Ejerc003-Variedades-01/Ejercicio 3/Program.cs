using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 1200;
            double hours = 60;
            double salariobruto = salary * hours;
            Console.WriteLine($"Su salario bruto es de {salariobruto}");
            //suponiendo que se aplica uno sobre lo que queda del otro
            double salarioneto = salariobruto * (1 - 0.11) * (1 - 0.03);
            Console.WriteLine($"Su salario bruto es de {salarioneto}");
            //suponiendo que e aplican por separado sobre el salario original
            //double salarioneto = salariobruto - salariobruto*0.11 - salariobruto*0.03;
            //
            //
        }
    }
}
