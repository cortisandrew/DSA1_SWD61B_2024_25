using ADTs_and_DSs.ABV;
using ADTs_and_DSs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DSs.QueueUsingABV
{
    public class Queue_ABV<T> : IQueueADT<T>
    {
        private ArrayBasedVector<T> _abv = new ArrayBasedVector<T>();
        public int Count => _abv.Count();

        public bool IsEmpty()
        {
            return _abv.IsEmpty();
        }

        public T Dequeue()
        {
            return _abv.RemoveElementAtRank(Count - 1);

            /*
            // since my newest element is at the rank count - 1
            // the oldest element is at the front of the array (index 0)
            return _abv.RemoveElementAtRank(0);
            */
        }

        public void Enqueue(T item)
        {
            _abv.InsertElementAtRank(0, item);

            // _abv.InsertElementAtRank(Count, item); // append the newest element
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }
    }
}
