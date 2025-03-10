using ADTs_and_DSs.LinkedListFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DSs.QueueUsingLinkedList
{
    public class Queue_LinkedList<T>
    {
        private SinglyLinkedList<T> singlyLinkedList = new SinglyLinkedList<T>();

        public int Count => singlyLinkedList.Count();

        public bool IsEmpty()
        {
            return singlyLinkedList.IsEmpty();
        }

        public T Dequeue()
        {
            return singlyLinkedList.RemoveFirst();

            // The following method, will be inefficient using a Singly Linked List
            // You would need a doubly linked list to work with this!
            // return singlyLinkedList.RemoveLast();
        }

        public void Enqueue(T element)
        {
            singlyLinkedList.InsertLast(element);
            //singlyLinkedList.InsertFirst(element);
        }

        public T Peek()
        {
            if (singlyLinkedList.Head == null) // equivalent to: IsEmpty()
            {
                throw new InvalidOperationException("There is no element to peek at! Invalid operation: You cannot call this operation when the queue is empty");
            }

            return singlyLinkedList.Head.Element;
        }
    }
}
