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
            {
                _root = new Node(value);
                _size++;
            }
            else
            {
                var current = _root;
                var completed = false;

                while (!completed)
                {
                    if (value < current.Value)
                    {
                        if (current.Left == null)
                        {
                            current.Left = new Node(value); 
                            break;
                        }                         
                       current = current.Left;
                    }
                    else
                    {
                       if (current.Right == null)
                       {
                          current.Right = new Node(value);
                          break;
                       }
                       current = current.Right;
                    }
                }
            }
        }

        public Node Lookup(int value)
        {
            var current = _root;

            while(true)
            {
                if (current.Value == value)
                    return current;

                if (value < current.Value)
                    current = current.Left;
                else
                    current = current.Right;
            }
        }
    }
}
