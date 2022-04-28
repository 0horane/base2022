using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc004_Programando_con_Objetos
{
    internal class Reloj
    {
        internal uint milliseconds, seconds, minutes, hours, timezone;

        internal Tuple<uint, uint> overflow (){

        }
        public Reloj(uint _ms = 0, uint _s = 0, uint _m = 0, uint _h = 0, uint _tm = 0) {
            /* unsafe {
                uint*[] inputnums = { &_ms, &_s, &_m, & };
            }
            while (_ms > 1000) { 
                
            } //dumb way pf foing things 
            */
            
            this.milliseconds = _ms;
            this.seconds = _s; 
            this.minutes = _m;
            this.hours = _h;
            this.timezone = _tm;
        }
    }
}
