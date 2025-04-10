using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructures
{
    /// <summary>
    /// Exercise: Implement the Vertex and BST using K : IComparable
    /// </summary>
    /// <typeparam name="V"></typeparam>
    public class BinaryTreeVertex<V> {
        public int Key { get; internal set; }
        public V Value { get; internal set; }

        public BinaryTreeVertex<V>? Left { get; internal set; }
        public BinaryTreeVertex<V>? Right { get; internal set; }

        public BinaryTreeVertex(int key, V value)
        {
            Key = key;
            Value = value;
        }

        internal void Add(int key, V value)
        {
            // Compare key with Key

            if (key < Key)
            {
                // Try to place the value to the left

                if (Left == null)
                {
                    // there is no Left subtree, but we have space available for a new vertex
                    Left = new BinaryTreeVertex<V>(key, value);
                }
                else
                {
                    Left.Add(key, value);
                }
            }
            else
            {
                // key >= Key
                // Try to place the value to the right

                if (Right == null)
                {
                    // there is no Left subtree, but we have space available for a new vertex
                    Right = new BinaryTreeVertex<V>(key, value);
                }
                else
                {
                    Right.Add(key, value);
                }
            }
        }
    }
}
