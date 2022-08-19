using System;
using System.Linq;

namespace Ejer008
{
    class Program
    {
        public class Agencia {

            private string nombre, direccion, titular;
            private Auto[] autos;
            public Agencia() {
                nombre = Input.String("Ingrese el nombre de la agencia", x=>x!="");
                direccion = Input.String("Ingrese la direccion de la agencia", x => x != "");
                titular = Input.String("Ingrese el nombre del titular de la agencia", x => x != "");

                autos = new Auto[Input.Int("Ingrese la cantidad de autos en la agencia", condition: x => x > 0)];
                for (int i = 0; i < autos.Length; i++) 
                    autos[i] = new Auto();
                
            }
            public void printdata() {
                Console.WriteLine($"Hay {autos.Length} autos");

                Console.WriteLine($"Las chasis combinadas pesan {autos.Sum(x => x.Chasis)}");
                Console.WriteLine($"Las chasis promedio pesan {autos.Select(x => x.Chasis).Average()}");
                Console.WriteLine($"Hay {autos.Count(x=>x.Anio==2020)} autos de 2020");

                /*
                Console.WriteLine($"Las chasis combinadas pesan {autos.Aggregate(0, (chasistotal, i) => chasistotal + i.Chasis)}");
                Console.WriteLine($"Las chasis promedio pesan {autos.Aggregate(0, (chasistotal, i) => chasistotal + i.Chasis, final => final / autos.Length)}");
                Console.WriteLine($"Hay {autos.Aggregate(0, (autos2020, i) => autos2020 + (i.Anio == 2020 ? 1 : 0))} autos de 2020");
                 */
            }
        }

        public class Auto
        {

            private string marca, modelo;
            private int anio, chasis;
            public int Anio { get { return anio; } set { anio = value; } }
            public int Chasis { get { return chasis; } set { chasis = value; } }
            public Auto()
            {
                marca = Input.String("Ingrese la marca del auto", x => x != "");
                modelo = Input.String("Ingrese el modelo del auto", x => x != "");
                anio = Input.Int("Ingrese el año del modelo del auto");
                chasis = Input.Int("Ingrese el peso de la chasis del auto", condition: x => x > 0);

                
            }
        }

        static void Main(string[] args)
        { 
            Agencia agencia = new Agencia();
            agencia.printdata();
        }
    }
}