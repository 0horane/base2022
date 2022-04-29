using System;

namespace Ejerc004_Programando_con_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Reloj reloj = new Reloj(500,62,2,18, -3);
            Console.WriteLine(reloj);
            Console.WriteLine(reloj.GetTime());
            Console.WriteLine(reloj.GetTime(0));
            reloj.SetTime(0,0,0,0);
            Console.WriteLine(reloj.GetTime());
            Console.WriteLine("\n\n");



            Jugador jugador = new Jugador();
            //jugador.MoverAdelante();
            //Console.WriteLine($"{jugador.posX} {jugador.posY} {jugador.velX} {jugador.velY}");
            char pkey;
            do
            {
                pkey = (char)Console.ReadKey().Key;
                if (pkey == 'M')
                {
                    jugador.MoverAdelante();
                }
                else if (pkey == 'Z')
                {
                    jugador.Girar();
                }
                else
                {
                    jugador.iter();
                }
                Console.WriteLine($"x: {jugador.posX} y:{jugador.posY} vx:{jugador.velX} vy:{jugador.velY} dir:{jugador.direccion*180}");

            }
            while (true);

            
        }
    }
}
