using System;

namespace Ejerc004_Programando_con_Objetos
{
    /// <summary>
    /// Clase para manejar un reloj hipotetico que no se auto actualiza. 
    /// </summary>
    internal class Reloj
    {
        internal int milliseconds, seconds, minutes, hours;
        internal int timezone;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_ms">Milisegundos del horario. Debe ser positivo</param>
        /// <param name="_s">Segundos del horario. Debe ser positivo</param>
        /// <param name="_m">Minutos del horario. Debe ser positivo</param>
        /// <param name="_h">Hoars del horario. Debe ser positivo</param>
        /// <param name="_tm">Zona horaria medida en diferencia positiva o negativa de UTC</param>
        /// <exception cref="Exception">Diferencia con UTC invalida</exception>
        public Reloj(int _ms = 0, int _s = 0, int _m = 0, int _h = 0, int _tm = 0)
        {
            if (!(-12 <= _tm && _tm <= 14)) {
                throw new Exception("Invalid UTC Offset");
            }
            this.SetTime(_ms, _s, _m, _h);
            this.timezone = _tm;
        }
        /// <summary>
        /// Funcion interna para convertir unidades positivas que se pasan del maximo
        /// </summary>
        /// <param name="amount">cantidad</param>
        /// <param name="overflowamount">cantidad maxima</param>
        /// <returns>tuple con cantidad final y las que pasan para arriba</returns>
        internal (int, int) overflow (int amount, int overflowamount){
            int overflowtotal = 0;

            while (amount >= overflowamount) {
                overflowtotal++;
                amount -= overflowamount;
            }
            return (amount, overflowtotal);

        }

        /// <summary>
        /// Estabecer el tiempo del reloj
        /// </summary>
        /// <param name="_ms">Milisegundos del horario. Debe ser positivo</param>
        /// <param name="_s">Segundos del horario. Debe ser positivo</param>
        /// <param name="_m">Minutos del horario. Debe ser positivo</param>
        /// <param name="_h">Hoars del horario. Debe ser positivo</param>
        /// <exception cref="Exception"></exception>
        public void SetTime(int _ms = 0, int _s = 0, int _m = 0, int _h = 0)
        {
            if (_ms < 0 || _s < 0 || _m < 0 || _h < 0) {
                throw new Exception("Time cannot be negative");
            }
            int tempnext;
            (this.milliseconds, tempnext) =  this.overflow( _ms, 1000);
            (this.seconds, tempnext) = this.overflow(_s + tempnext, 60);
            (this.minutes, tempnext) = this.overflow(_m + tempnext, 60);
            (this.hours, tempnext) = this.overflow(_s + tempnext, 24);
        }

        /// <summary>
        /// Devuelve el tiempo del reloj
        /// </summary>
        /// <returns>Tuple con (milisegundos, segundos, minutos, horas)</returns>
        public (int, int, int, int) GetTime() {
            return (this.milliseconds, this.seconds, this.minutes, this.hours);
        }

        /// <summary>
        /// Devuelve el tiempo del reloj en otra zona horaria
        /// </summary>
        /// <param name="offset">Zona horaria medida en diferencia positiva o negativa de UTC</param>
        /// <returns>Tuple con (milisegundos, segundos, minutos, horas)</returns>
        public (int, int, int, int) GetTime(int offset)
        {
            int hours = this.hours - offset + this.timezone;
            if (hours < 0)
            {
                hours = 24 + hours;
            }
            return (this.milliseconds, this.seconds, this.minutes, hours);
        }
    }
}
