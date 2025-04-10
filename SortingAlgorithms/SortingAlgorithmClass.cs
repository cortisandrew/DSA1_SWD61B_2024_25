using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SortingAlgorithmClass
    {
        /// <summary>
        /// The MergeSort is a recursive algorithm
        /// </summary>
        /// <param name="array">An unsorted array of length n (where n is the problem size)</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int[] MergeSort(int[] array)
        {
            int n = array.Length;

            // Step i: Base Case
            if (n <= 1)
            {
                // This is trivially sorted! Array of length 1 (or less) already has all the elements
                // in order
                return array;
            }

            // Take the first half of the array
            int[] p1_unsorted = array.Take(n / 2).ToArray();

            // Take all the remaining elements of the array
            int[] p2_unsorted = array.Skip(n / 2).Take(n - (n / 2)).ToArray();

            // Recursive calls
            // Because of the Base Case, this will be able to return a correctly sorted array
            // 2 recursive calls, with length n / 2 (about)
            int[] p1_sorted = MergeSort(p1_unsorted);
            int[] p2_sorted = MergeSort(p2_unsorted);

            // Merge the two SORTED arrays together to finish the sorting here!
            // Return all the elements sorted
            // Merge takes Theta(n) time
            return Merge(p1_sorted, p2_sorted);
        }

        /// <summary>
        /// The merge will take 2 SORTED arrays as parameters
        /// And will merge them into a single sorted array
        /// (If the inputs are NOT sorted, the Merge will not work successfully!)
        /// </summary>
        /// <param name="p1_sorted">MUST be sorted!</param>
        /// <param name="p2_sorted">MUST be sorted!</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private int[] Merge(int[] p1_sorted, int[] p2_sorted)
        {
            int[] output = new int[p1_sorted.Length + p2_sorted.Length];

            int k = 0; // k will keep track of the next empty space in the output array

            int i = 0; // i will keep track of the smallest element in p1_sorted
                        // that has not yet been copied to the output
            int j = 0; // j will keep track of the smallest element in p2_sorted
                       // that has not yet been copied to the output

            // while there are still elements in both p1_sorted and p2_sorted to copy
            while (i < p1_sorted.Length && j < p2_sorted.Length) { 
                // i is pointing towards p1_sorted[i]
                // j is pointing towards p2_sorted[j]

                // find the smallest element (that has not yet been copied)
                // copy the smallest element over to the output
                if (p1_sorted[i] <= p2_sorted[j])
                {
                    // p1_sorted[i] is the smallest element
                    output[k] = p1_sorted[i];
                    i++; // since p1_sorted[i] was copied, i can move forward one step
                }
                else
                {
                    // p2_sorted[j] is the smallest element
                    output[k] = p2_sorted[j];
                    j++; // since p2_sorted[j] was copied, j can move forward one step
                }

                k++; // position k is occupied, move k to the next availale position
            }

            // eventually either i "exits" p1_sorted OR j "exits" p2_sorted
            // in this case, we have taken ALL the elements from one of the arrays

            while (i < p1_sorted.Length)
            {
                // there are still some elements from p1_sorted to be copied...
                // copy the next one
                output[k] = p1_sorted[i];
                k++;
                i++;
            }

            while (j < p2_sorted.Length)
            {
                // there are still some elements from p2_sorted to be copied...
                // copy the next one
                output[k] = p2_sorted[j];
                k++;
                j++;
            }

            return output;
        }
    }
}
