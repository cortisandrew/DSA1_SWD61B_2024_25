using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DSs.Interfaces
{
    public interface IQueueADT<T>
    {
        int Count { get; }

        bool IsEmpty();

        void Enqueue(T item);

        T Dequeue();

        T Peek();
    }
}
