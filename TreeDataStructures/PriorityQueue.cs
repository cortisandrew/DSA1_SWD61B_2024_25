using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructures
{
    /// <summary>
    /// Elements are dequeue in highest priority first order
    /// Smaller key means a higher priority
    /// </summary>
    public class PriorityQueue
    {
        BinaryMinHeap heap = new BinaryMinHeap();

        public void Enqueue(int key /*, T data */)
        {
            heap.Add(key);
        }

        public int Dequeue()
        {
            return heap.RemoveMin();
        }
    }
}
