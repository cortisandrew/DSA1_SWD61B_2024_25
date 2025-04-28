using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructures
{
    public class BinaryMinHeap
    {
        private List<int> arrayBasedVector = new List<int>();

        private int LeftChildIndex(int parentIndex)
        {
            return (parentIndex * 2) + 1;
        }

        private int RightChildIndex(int parentIndex) 
        { 
            return (parentIndex * 2) + 2;
        }

        private int ParentIndex(int childIndex)
        {
            return (int)Math.Floor((double)(childIndex - 1) / 2);
        }

        public void Add(int key)
        {
            arrayBasedVector.Add(key); // append the key to the binary min heap
                                       // preserves Complete Property
                                       // Heap-Order might be lost at the index of the new key

            Upheap(arrayBasedVector.Count - 1); // call Upheap with the index of the newly added key  
        }

        /// <summary>
        /// Perform an uphead (BubbleUp) at the index, to restore the heap order
        /// </summary>
        /// <param name="index"></param>
        public void Upheap(int index)
        {
            if (index == 0)
            {
                // the key is at the root
                // there is NO smaller parent
                return; // Heap Order is restored!
            }

            int parentIndex = ParentIndex(index);

            int parentValue = arrayBasedVector[parentIndex];
            int childValue = arrayBasedVector[index];

            if (parentValue > childValue)
            {
                // we need to swap!
                arrayBasedVector.Swap(index, parentIndex);
                Upheap(parentIndex);
            }
            // else, we do not need to swap - therefore Heap Order is restored
        }

        public int RemoveMin()
        {
            int output = arrayBasedVector[0]; // the root has the smallest element
            arrayBasedVector[0] = arrayBasedVector[arrayBasedVector.Count - 1]; // copy the last element to the root
            arrayBasedVector.RemoveAt(arrayBasedVector.Count - 1); // remove the last element

            // the Heap is complete
            // BUT we don't have heap order at index 0
            DownHeap(0);

            return output;
        }

        private void DownHeap(int index)
        {
            // compare the key at index, with the key of the smallest child (if any)
            // if the key at index is LARGER than the smallest Child, SWAP and continue downheap
            // otherwise, we are ready!

            // How many children do we have?
            int leftChildIndex = LeftChildIndex(index);

            if (leftChildIndex >= arrayBasedVector.Count)
            {
                // case (i) no children
                // there are no children to compare against
                // heap-order is now restored
                return;
            }

            int smallestChildIndex;
            if (leftChildIndex == arrayBasedVector.Count - 1)
            {
                // case (ii) - exactly one child!
                smallestChildIndex = leftChildIndex;
            }
            else
            {
                // case (iii) - there are two children to compare against!
                int rightChildIndex = RightChildIndex(index);
                if (arrayBasedVector[leftChildIndex] < arrayBasedVector[rightChildIndex])
                {
                    smallestChildIndex = leftChildIndex;
                }
                else
                {
                    smallestChildIndex = rightChildIndex;
                }
            }

            // compare the key against the key of the smallest child
            if (arrayBasedVector[index] > arrayBasedVector[smallestChildIndex])
            {
                // we need to swap to restore Heap-Order, continue downheap!
                arrayBasedVector.Swap(index, smallestChildIndex);
                DownHeap(smallestChildIndex);
            }
            // else heap-order is restored - no need to do anything else!
        }

        /// <summary>
        /// Assume that the are no duplicate keys...
        /// WARNING: will produce an incorrect diagram if you have duplicate keys!
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Graph G {");

            for (int index = 0; index < arrayBasedVector.Count; index++)
            {
                int key = arrayBasedVector[index];
                sb.Append(key.ToString());
                sb.AppendLine(";");

                // check how many children my vertex has...
                int leftChildIndex = LeftChildIndex(index);

                if (leftChildIndex >= arrayBasedVector.Count)
                {
                    // no children
                    continue;
                }

                if (leftChildIndex == arrayBasedVector.Count -1) { 
                    // exactly one child
                    sb.AppendLine(key.ToString() + " -- " + arrayBasedVector[leftChildIndex] + ";");
                }
                else
                {
                    // two children
                    sb.AppendLine(key.ToString() + " -- " + arrayBasedVector[leftChildIndex] + ";");
                    sb.AppendLine(key.ToString() + " -- " + arrayBasedVector[leftChildIndex + 1] + ";");
                }
            }

            sb.AppendLine("}");
            return sb.ToString();
        }
    }


}
