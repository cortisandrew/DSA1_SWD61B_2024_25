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

        /// <summary>
        /// The tail of list points towards the last SLL Node in the list, which stores
        /// the last element of the list (if it exists)
        /// If the list is empty, no elements exist and this points towards null
        /// </summary>
        /// <remarks>I will need this and add the information later...</remarks>
         private SinglyLinkedListNode<T>? tail = null;

        /// <summary>
        /// Keeps track of the number of elements stored within the linked list
        /// </summary>
        private int count = 0;

        public int Count() { return count; }

        public bool IsEmpty() {
            return count == 0;
            //return head == null;
        }

        /// <summary>
        /// Inserts a new element at the head of list
        /// </summary>
        /// <param name="element"></param>
        public void InsertFirst(T element)
        {
            // Step (i) - build new data
            SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>(element);

            // Step (ii) - update the next of the new node to the "old" head of list
            newNode.Next = head;

            if (head == null)
            {
                // currently, there are no nodes in the list
                // the new node will be the only node in the list
                // therefore it is BOTH the first and the last node
                tail = newNode;
            }

            // Step (iii) - update the head of list
            // This is a destructive step, because the old reference in the head is now lost!
            head = newNode;

            // Step (iv) - increment count
            count++;
        }

        public void InsertLast(T element)
        {
            // The current implementation "assumes" that I don't have a tail reference

            // Step i) get the head of list and refer to it as cursor
            SinglyLinkedListNode<T> cursor = head;

            // Step ii) Check for special case: empty linked list
            if (cursor == null) // Head was null because linked list was empty
            {
                InsertFirst(element); // Since there are currently no elements,
                                      // the new element will be both the first and last element
                return; // return so that the code does not fall through
            }

            /* This old method goes through all the nodes in the list: It is not needed if we have a reference to the tail
            // Step iii) Find the tail of the list
            while (cursor.Next != null) // while cursor is NOT the tail
            {
                cursor = cursor.Next; // move one step forward
            }
            */

            /*
            if (tail == null)
            {
                throw new ApplicationException("I have a bug in my code! Tail should NOT be null!");
            }*/

            cursor = tail!; // we know that the tail is not null, because there is at least one element!

            // cursor is the tail of the list!

            // Step iv) Now that I have the tail of list
            InsertAfterNode(cursor, element); // Inserting after the tail, is equivalent to InsertLast
        }

        public T RemoveFirst() {
            // if (count == 0)
            if (head == null)
            {
                // the linked list is empty!
                throw new InvalidOperationException("The list is empty, there is nothing to remove");
            }

            // head != null
            T elementToReturn = head.Element;

            head = head.Next; // head will now "skip" the first node

            if (head == null)
            {
                // I have removed all of the elements from the list
                // i.e. count == 0

                // Since all the nodes are now removed,
                // There is no tail
                tail = null;
            }

            count--;
            return elementToReturn;
        }

        /// <summary>
        /// Remove the tail of the list
        /// Return the element found in the tail
        /// Update the references to the tail (and possibly the head of list)
        /// </summary>
        /// <returns></returns>
        public T RemoveLast() {

            // Case (i) - no elements. This is the only time that tail should be null!
            // if (count == 0)
            if (head == null)
            {
                // the linked list is empty!
                throw new InvalidOperationException("The list is empty, there is nothing to remove");
            }

            // Case (ii)
            // There is only one node in the linked list
            // Count == 1
            // Head == Tail (there is only one node and therefore, the node is BOTH the head and tail of list
            if (head == tail)
            {
                return RemoveFirst(); // this case is already solved in the RemoveFirst operation
            }

            // Case (iii)
            // There are multiple nodes in the list (count > 1)
            T elementToReturn = tail!.Element; // We know that the tail is not null!

            SinglyLinkedListNode<T> cursor = head; // we know that cursor does NOT start off as null
            // we would like the cursor to point towards the node that is previous to the tail
            // i.e. we want cursor.Next == tail

            // while the cursor is NOT the node that is previous to the tail
            while(cursor!.Next != tail)
            {
                cursor = cursor.Next!; // move forward until we find the node we are looking for

                if ( cursor == null || cursor.Next == null)
                {
                    // this can only happen if there is an issue with the code somewhere
                    // this case should NOT happen...
                    throw new ApplicationException("There is a bug in some operation that needs to be fixed!");
                }
            }

            // the cursor is now the previous of the tail
            // after removing the tail, the cursor is the new tail
            cursor.Next = null;
            tail = cursor;

            // remember to reduce the count (we have removed one node!)
            count--;

            // return the element we need
            return elementToReturn;

        }


        public void InsertAfterNode(SinglyLinkedListNode<T> cursor, T element)
        {
            // Validation: this parameter value does not make sense!
            if (cursor == null)
            {
                throw new ArgumentNullException(nameof(cursor), "You cannot insert after a null!");
            }

            // Step i) Create the new node
            SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>(element);

            // Step ii) Update the new node's next
            newNode.Next = cursor.Next;

            // cursor might be the tail of list... if this is the case,
            // you will need to update the tail!
            if (cursor.Next == null) // cursor == tail
            {
                // we are adding a new node AFTER the tail... therefore the new node is the tail!
                tail = newNode;
            }

            // Step iii) add the new node to the linked list
            cursor.Next = newNode;

            // Step iv) increment count
            count++;
        }

        public T RemoveAfterNode(SinglyLinkedListNode<T> cursor)
        {
            throw new NotImplementedException("Exercise");
        }

        public void InsertBeforeNode(SinglyLinkedListNode<T> cursor, T element)
        {
            /*
            if (cursor.LinkedList != this)
            {
                // the cursor is not an element of this linked list!
                // You cannot add to this linked list with this cursor!
            }
            */

            throw new NotImplementedException("Exercise");
        }

        /// <summary>
        /// Go over each node, one after the other and take a copy of the elements
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[ ");
            // Store all the elements here...
            List<T> arrayBasedVector = new List<T>();

            // starting from the first node in the list
            SinglyLinkedListNode<T>? cursor = head;

            // go over each and every node in the list
            while (cursor != null)
            {
                // copy the element over
                arrayBasedVector.Add(cursor.Element);
                
                // move forward one step
                cursor = cursor.Next;
            }
            sb.Append(String.Join(", ", arrayBasedVector));
            sb.Append("] ");
            return sb.ToString();
        }


    }
}
