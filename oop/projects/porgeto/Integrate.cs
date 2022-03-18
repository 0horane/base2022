using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porgeto
{
    class integrate
    {
        internal int _dx;

        public int definite_summation(Func<int,int> intfunction, int lowerbound, int upperbound)
        {
            Accumulator integrator = new Accumulator((x, y)=>x+intfunction(y), x=>x+_dx, 0 );
            integrator.accumulate(lowerbound, upperbound);
        }

    }
}
