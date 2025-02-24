using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DSs.Interfaces
{
    /// <summary>
    /// A stack ADT represent a set of elements that can be added to. Elements are removed in a Last In First Out manner
    /// That is, the most recently added element, is the first to be removed
    /// (i.e. imagine a stack of heavy boxes)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStackADT<T>
    {
        /// <summary>
        /// Returns the number of elements on the stack
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Returns whether there are any elements on the stack
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// Add an element to the top of the stack
        /// </summary>
        /// <param name="item"></param>
        void Push(T item);

        /// <summary>
        /// Remove the last element to be added to the stack (i.e. the element at the top of the stack)
        /// </summary>
        /// <returns></returns>
        T Pop();

        /// <summary>
        /// Return the element at the top of the stack, without removing it
        /// </summary>
        /// <returns></returns>
        T Peek();
    }
}
