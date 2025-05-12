using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDataStructures;

namespace PRNG
{
    public class FYShuffle
    {
        private LCG lcg = new LCG();

        public void Shuffle(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n-1; i++)
            {
                // get a random item to swap with position i
                // each of the "remaining" elements, has equal probability to be selected
                int j = lcg.Next(i, n);

                a.Swap(i, j);
            }
        }
    }
}
