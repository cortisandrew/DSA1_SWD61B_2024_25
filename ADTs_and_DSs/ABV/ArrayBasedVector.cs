using ADTs_and_DSs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DSs.ABV
{
    /// <summary>
    /// The ArrayBasedVector is a data structure
    /// The ABV is a concrete implementation of an ADT (in this case, the VectorADT)
    /// </summary>
    /// <typeparam name="T">The data type of the elements that will be stored in the ABV</typeparam>
    public class ArrayBasedVector<T> : IVectorADT<T>
    {
        private const int INITIAL_ARRAY_SIZE = 4;

        /// <summary>
        /// The array that will be used to store the elements of the Vector
        /// The data type is T, which is passed as a type parameter
        /// </summary>
        private T[] array = new T[INITIAL_ARRAY_SIZE];

        public ArrayBasedVector() {
        }

        public ArrayBasedVector(T[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                array[i] = values[i];
            }

            count = values.Length;
        }


        /// <summary>
        /// The current number of elements being stored (initially 0)
        /// </summary>
        private int count = 0;
        public int Count()
        {
            return count;
        }
        public bool IsEmpty()
        {
            return count == 0;

            /*
            if (Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
        }


        public T GetElementAtRank(int rank)
        {
            // Validation: check that the parameter rank is fine!
            if (rank < 0 || rank >= count)
            {
                // there is no element to retrieve here!
                throw new ArgumentOutOfRangeException(nameof(rank),
                    $"The rank you provided as a parameter is outside of acceptable range! You can only pass ranks between 0 and {Count() - 1}, both inclusive (i.e. Count() - 1");
            }

            return array[rank];
        }

        public void InsertElementAtRank(int rank, T element)
        {
            if (count == array.Length)
            {
                // The array is now full, we cannot add the new element in the array that we have now
            
                // Create a new larger array
                T[] newArray = new T[array.Length * 2]; // create a new array which is double the length of the old array

                // copy everything over to the new array
                array.CopyTo(newArray, 0); // equivalent to the code below...

                /*
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                */

                // replace the array with the new array
                array = newArray;
            }

            if (rank < 0 || rank > count)
            {
                // there rank chosen is not acceptable!
                throw new ArgumentOutOfRangeException(nameof(rank),
                    $"The rank you provided as a parameter is outside of acceptable range! You can only pass ranks between 0 and {Count()}, both inclusive (i.e. Count()");
            }

            // starting from the position the last element (at position count - 1)
            // down to the location I want to free up (i = rank)
            for (int i = count - 1; i >= rank; i--)
            {
                // get the element at index i and place it in index i + 1
                array[i + 1] = array[i];
            }

            // place the new element at the correct position
            array[rank] = element;
            // increase count (we are storing a new element)
            count++;
        }

        public T RemoveElementAtRank(int rank)
        {
            throw new NotImplementedException();
        }

        public T ReplaceElementAtRank(int rank, T newElement)
        {
            // Get the element at rank
            // Update the element at the rank with the new element
            // return the old element
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[");
            stringBuilder.Append(
                String.Join(", ", array.Take(count)));
            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }
    }
}
