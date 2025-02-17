using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DSs.Interfaces
{
    /// <summary>
    /// Classes that implement this interface are going to represent a Vector ADT
    /// This means, that the class will store an ordered sequence of elements
    /// The elements can be referred to using the rank (number of elements before the current element)
    /// The Vector must implement the operations (methods) in the interface
    /// </summary>
    /// <typeparam name="T">The data type for the elements that we are going to store</typeparam>
    public interface IVectorADT<T>
    {
        /// <summary>
        /// Returns the number of elements stored within the IVectorADT
        /// </summary>
        /// <returns>The number of elements stored</returns>
        int Count();

        /*
        int Count
        {
            get;
        }
        */

        /// <summary>
        /// Returns whether the IVectorADT contains any elements
        /// </summary>
        /// <returns>True if there are 0 elements stored, False otherwise</returns>
        bool IsEmpty();

        /// <summary>
        /// Returns the element at the rank passed as a parameter
        /// </summary>
        /// <param name="rank">The rank of the object to retrieve</param>
        /// <returns>The object at the rank</returns>
        T GetElementAtRank(int rank);

        /// <summary>
        /// Inserts a new element at the rank passed as a parameter (shifting other elements backwards if necessary)
        /// </summary>
        /// <param name="rank">The rank of the new element</param>
        /// <param name="element">The element to be stored at the given rank</param>
        void InsertElementAtRank(int rank, T element);

        /// <summary>
        /// Replaces the element at the rank passed as a parameter with a newElement. The old element that is replaced
        /// is returned
        /// </summary>
        /// <param name="rank">The rank of the element to be replaced</param>
        /// <param name="newElement">The new element to replace the old element</param>
        /// <returns>The old element which was replaced</returns>
        T ReplaceElementAtRank(int rank, T newElement);

        /// <summary>
        /// Remove the element at the rank passed as a parameter (shifting the elements forward if necessary)
        /// </summary>
        /// <param name="rank">The rank of the element to be removed</param>
        /// <returns>The element which was removed</returns>
        T RemoveElementAtRank(int rank);
    }
}
