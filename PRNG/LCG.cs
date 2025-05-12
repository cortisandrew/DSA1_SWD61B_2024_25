using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRNG
{
    public class LCG
    {
        int _state = 0;
        int state
        {
            get
            {
                return _state;
            }
            set
            {
                _state = (int)Math.Abs(value % m);
            }
        }

        int a = 19;
        int c = 7;
        int m = 23;

        public LCG() {
            state = DateTime.Now.Nanosecond;
        }

        public LCG(int seed)
        {
            state = seed;
        }

        public int Next()
        {
            state = (a * state + c) % m;
            return state;
        }

        /// <summary>
        /// Returns a random number between min (inclusive) and max (exclusive)
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /// <remarks>For a die roll, call Next(1, 7)</remarks>
        public int Next(int min, int max)
        {
            int diff = max - min;

            int r_1 = (diff * Next()) / m;

            return r_1 + min;

            // inferior code
            // the code below can introduce a bias in your output
            // return (Next() % (max - min)) + min;
        }
    }
}
