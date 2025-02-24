using ADTs_and_DSs.ABV;
using ADTs_and_DSs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DSs.StackUsingABV
{
    public class Stack_ABV<T> : IStackADT<T>
    {
        /// <summary>
        /// Aggregation: We are using the ABV as a field
        /// </summary>
        private ArrayBasedVector<T> _abv = new ArrayBasedVector<T>();

        public int Count => _abv.Count();

        public bool IsEmpty()
        {
            return _abv.IsEmpty();
        }

        public T Pop()
        {
            // Correct (most efficient) implementation
            return _abv.RemoveElementAtRank(_abv.Count() - 1); // remove the element from the top of the stack

            // return _abv.RemoveElementAtRank(0);
        }

        public void Push(T item)
        {
            // Correct (most efficient) implementation
            _abv.InsertElementAtRank(_abv.Count(), item); // this means that the top of the stack is at rank count

            // This method is inefficient (remember we need to move all the elements to make room for the new element)
            // _abv.InsertElementAtRank(0, item); // insert at rank 0, this means that the top of the stack is at rank 0
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }
    }
}
