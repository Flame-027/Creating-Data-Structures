
namespace Linked_List_Implementation
{
    public class DoubleNode
    {
        public int Value { get; set; }
        public DoubleNode? Previous { get; set; }
        public DoubleNode? Next { get; set; }

        public DoubleNode(int input)
        {
            this.Value = input;
        }
    }

}
