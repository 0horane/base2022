
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porgeto
{
    class Accumulator
    {
        internal Func<int, int, int> _combiner;
        internal Func<int, int> _next;
        internal int _nullvalue;
        public Accumulator(Func<int, int, int> acombiner, Func<int, int> anext, int anullvalue) {
            this._combiner = acombiner;
            this._next = anext;
            this._nullvalue = anullvalue;

        }
        public int accumulate(int from, int to) {
            int counter = _nullvalue;
            for (int i = from; i < to; i = _next(i)){
                counter = _combiner(counter, i);
            }
            return counter;
        }
    }
}
