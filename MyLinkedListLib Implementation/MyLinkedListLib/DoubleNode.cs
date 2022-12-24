
namespace Linked_List_Implementation
{
    public class DoubleNode<T>
    {
        public T Value { get; set; }
        public DoubleNode<T>? Previous { get; set; }
        public DoubleNode<T>? Next { get; set; }

        public DoubleNode(T input)
        {
            this.Value = input;
        }
    }

}
