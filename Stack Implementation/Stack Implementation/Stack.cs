using Linked_List_Implementation;

namespace Stack_Implementation
{
    public class Stack
    {
        private MyLinkedList? linkedList;
        private Node? top;
        private Node? bottom;
        public int Length { get; private set; }

        public Stack() { }

        public Stack(params int[] input)
        {
         linkedList = new MyLinkedList(input);
         Length = linkedList.Length;
        }

        public void Push(int value)
        {
         if (linkedList == null)
            linkedList = new MyLinkedList(value);
         else
            linkedList.Append(value);

          bottom = linkedList.Head;
          top = linkedList.Tail;
          Length = linkedList.Length;
        }

        public int Peak()
        {
            if (bottom == null)
                throw new InvalidOperationException();

            return top.Value;
        }
        
        public void Remove()
        {
            linkedList.Remove(Length - 1);
        }
      
        public bool IsEmtpy()
        {
            if (bottom == null)
                return true;
            else
                return false;
        }
      

    }
}
