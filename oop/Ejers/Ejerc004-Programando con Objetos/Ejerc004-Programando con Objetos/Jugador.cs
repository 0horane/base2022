using System;

namespace Ejerc004_Programando_con_Objetos
{

    internal class Jugador
    {

        public double posX, posY, velX, velY, direccion;
        /// <summary>
        /// Un jugador hipotetico de un juego com movimiento
        /// </summary>
        /// <param name="_posX">Posicion x del jugador</param>
        /// <param name="_posY">Posicion Y del jugador</param>
        /// <param name="_velX">Velocidad en x del jugador</param>
        /// <param name="_velY">Velocidad en y del jugador</param>
        /// <param name="_direccion">Radianes de rotacion desde el eje x de -1 a 1</param>
        /// <exception cref="Exception"></exception>
        public Jugador(double _posX = 0, double _posY = 0, double _velX = 0, double _velY = 0, double _direccion = 0) {
            if (!(-1 < _direccion && _direccion <= 1))
            {
                throw new Exception("Direccion invalida");
            }
            this.posX = _posX;
            this.posY = _posY;
            this.velX = _velX;
            this.velY = _velY;
            this.direccion = _direccion;
        }

        /// <summary>
        /// actualiza la posicion del jugador segun la velocidad.
        /// </summary>
        public void iter()
        {
            posX += velX;
            posY += velY;
            velX *= 0.8;
            velY *= 0.8;

            {
                for (int i = 0; i < 40; i++)
                {
                    for (int j = 0; j < 80; j++)
                    {
                        if (Math.Round(this.posY) == i-20 && Math.Round(this.posX) == j-40)
                        {
                            Console.Write("X");
                        } else if (Math.Round(this.posY+ Math.Sin(direccion) * 3) == i - 20 && Math.Round(this.posX + Math.Cos(direccion) * 3) == j - 40)
                        {
                            Console.Write(".");
                        } else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("\n");
                }
            }

        }

        /// <summary>
        /// Convierte unidades pasadas del maximo al corresponiente
        /// </summary>
        /// <param name="inputdbl">numero de ingreso</param>
        /// <param name="min">valor minimo</param>
        /// <param name="max">valor maximo</param>
        /// <returns>valor dentro del rango</returns>
        internal double overflow(double inputdbl, double min, double max)
        {
            while (min < inputdbl && inputdbl < max)
            {
                if (inputdbl > max)
                {
                    inputdbl -= max-min;
                } else {
                    inputdbl += max - min;
                }
            }
            return inputdbl;
        }

        /// <summary>
        /// Acelera en la direccion actual y itera
        /// </summary>
        public void MoverAdelante()
        {
            this.velX += Math.Cos(direccion);
            this.velY += Math.Sin(direccion);
            this.iter();
        }
        /// <summary>
        /// Gira la direccion y itera
        /// </summary>
        public void Girar()
        {
            
            this.direccion -= 0.4;
            this.iter();
        }
    }
}
