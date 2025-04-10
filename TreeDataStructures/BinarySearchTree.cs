using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructures
{
    public class BinarySearchTree<V>
    {
        public BinaryTreeVertex<V>? Root { get; internal set; }

        public void Add(int key, V value)
        {
            if (Root == null)
            {
                // The BST is empty, there is no root!
                // Place the new value at the root!
                Root = new BinaryTreeVertex<V>(key, value);
                return; // While not required here, forgetting to return and falling through to another case
                        // is a common mistake! Be Careful!
            }
            else
            {
                Root.Add(key, value);
                return;
            }
        }

        public V Search(int key) { throw new NotImplementedException(); }

        public bool Contains(int key) { throw new NotImplementedException("Exercise!"); }
    }
}
