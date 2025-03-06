using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DSs.LinkedListFolder
{
    /// <summary>
    /// A singly linked list containing elements of type T
    /// </summary>
    /// <typeparam name="T">The type of element we want to store</typeparam>
    public class SinglyLinkedList<T>
    {
        /// <summary>
        /// The head of list points towards the instance of type SLL Node that stores
        /// the first element of the list
        /// If there are no elements, the head of list will point towards null (i.e. there is no node and no elements being stored)
        /// </summary>
        private SinglyLinkedListNode<T>? head = null;

        public SinglyLinkedListNode<T>? Head
        {
            get { return head; }
        }

        /*
        /// <summary>
        /// The tail of list points towards the last SLL Node in the list, which stores
        /// the last element of the list (if it exists)
        /// If the list is empty, no elements exist and this points towards null
        /// </summary>
        /// <remarks>I will need this and add the information later...</remarks>
         private SinglyLinkedListNode<T>? tail = null;
        */

        /// <summary>
        /// Keeps track of the number of elements stored within the linked list
        /// </summary>
        private int count = 0;

        public int Count() { return count; }

        public bool IsEmpty() {
            return count == 0;
            //return head == null;
        }

        public void InsertFirst(T element)
        {
            throw new NotImplementedException();
        }

        public void InsertLast(T element)
        {
            throw new NotImplementedException();
        }

        public T RemoveFirst() { throw new NotImplementedException(); }

        public T RemoveLast() {  throw new NotImplementedException(); }


        public void InsertAfterNode(SinglyLinkedListNode<T> cursor, T element)
        {
            throw new NotImplementedException();
        }

        public T RemoveAfterNode(SinglyLinkedListNode<T> cursor)
        {
            throw new NotImplementedException();
        }

        public void InsertBeforeNode(SinglyLinkedListNode<T> cursor, T element)
        {
            throw new NotImplementedException();
        }



    }
}
