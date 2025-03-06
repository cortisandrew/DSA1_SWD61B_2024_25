using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DSs.LinkedListFolder
{
    /// <summary>
    /// Represents a single node in the linked list
    /// Stores a single element of type T
    /// (Does something else as well)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SinglyLinkedListNode<T>
    {
        /// <summary>
        /// The element which is being stored within this node
        /// </summary>
        private T element;

        public T Element
        {
            get { return element; }
            internal set { element = value; }
        }

        /// <summary>
        /// A pointer/reference to the next node in the linked list
        /// If this is the tail of list, the next node does not exist!
        /// In this case, we use a null
        /// </summary>
        private SinglyLinkedListNode<T>? next = default;

        public SinglyLinkedListNode<T>? Next
        {
            get { return next; }
            internal set { next = value; }
        }

        public SinglyLinkedListNode(T element)
        {
            this.element = element;
        }

        public SinglyLinkedListNode(T element, SinglyLinkedListNode<T>? next) : this(element)
        {
            this.next = next;
        }
    }
}
