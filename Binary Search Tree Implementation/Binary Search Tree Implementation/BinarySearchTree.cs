using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree_Implementation
{
    public class BinarySearchTree
    {
        private Node _root;
        private int _size;

        public BinarySearchTree() { }

        public BinarySearchTree(int value)
        {
            Insert(value);
        }

        public void Insert(int value)
        {
            if (_size == 0)
                _root.Value = value;
            else
            {
                var current = _root;
                bool completed = false;

                while (!completed)
                {
                    if (current == null)
                    {
                        current = new Node(value);
                        completed = true;
                    }
                    if (value < current.Value)
                        current = current.Left;
                    else
                        current = current.Right;
                }
                _size++;
            }

        }
    }
}
