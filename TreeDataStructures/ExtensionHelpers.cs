using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructures
{
    public static class ExtensionHelpers
    {
        /// <summary>
        /// Swaps the elements at index i and index j of the List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void Swap<T>(this List<T> array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
