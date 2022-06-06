using System;

namespace Ejer007
{
    public class zoologico
   {
        private string nombre, direccion, loc;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Loc { get { return loc; } set { loc = value; } }

        public zoologico(){
            Console.WriteLine("Ingrese el nombre del zoologico");
            this.Nombre = Console.ReadLine(); 
            Console.WriteLine("Ingrese la direccion del zoologico");
            this.Direccion = Console.ReadLine(); 
            Console.WriteLine("Ingrese la provincia del zoologico");
            this.Loc = Console.ReadLine(); ;
        }
    }
    /*
    public class animal
    {
        public string nombre { get { return nombre; } set { nombre = value; } }
        public string color { get { return color; } set { color = value; } }
        public int peso { get { return peso; } set { peso = value; } }
        public int edad { get { return edad; } set { edad = value; } }

        public animal(string nombre, string direccion, string loc)
        {
            this.nombre = nombre;
            this.color = color;
            this.peso = peso;
            this.edad = edad;
        }
    }*/ 
    internal class Program
    {
        static int inputint(string message= "Ingrese un numero")
        {
            int inputint;
            do
            {
                Console.WriteLine(message);
            } while (!Int32.TryParse(Console.ReadLine(), out inputint));
            return inputint;
        }
        static void Main(string[] args)
        {
            zoologico zoo = new zoologico();
            int iint = inputint("Cuantos animales deseas ingresar");
            string[] nombres = new string[iint];
            string[] colores = new string[iint];
            int[] pesos = new int[iint];
            int[] edades = new int[iint];

            for (int i = 0; i < iint; i++)
            {
                Console.WriteLine("Ingrese el nombre del animal");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el color del animal");
                colores[i] = Console.ReadLine();
                pesos[i] = inputint("Ingrese el peso del animal");
                edades[i] = inputint("Ingrese la edad del animal");
            }
            int psum=0, pmin= pesos[0], pmax= pesos[0], esum=0, emax= edades[0], emin= pesos[0];
            Console.WriteLine($"El zoologico se llama {zoo.Nombre}, en la direccion {zoo.Direccion}, en la provincia {zoo.Loc}");
            for (int i = 0; i < iint; i++)
            {
                Console.WriteLine($"El {i}° animal se es un {nombres[i]}, de color {colores[i]}, con un peso de {pesos[i]} y edad de {edades[i]}");
                if (edades[i] > emax)
                    emax= edades[i];
                if (edades[i] < emin)
                    emin = edades[i];
                if (pesos[i] > pmax)
                    pmax = pesos[i];
                if (pesos[i] < pmin)
                    pmin = pesos[i];
                psum += pesos[i];
                esum += edades[i];

            }
            Console.WriteLine($"El peso promedio es de {psum/iint}");
            Console.WriteLine($"El peso maximo es de {pmax}");
            Console.WriteLine($"El peso minimo es de {pmin}");
            Console.WriteLine($"La edad promedio es de {esum/iint}");
            Console.WriteLine($"La edad maxima es de {emax}");
            Console.WriteLine($"La edad minima es de {emin}");


        }
    }
}