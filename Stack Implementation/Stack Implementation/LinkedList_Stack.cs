using Linked_List_Implementation;

namespace Stack_Implementation
{
    public class LinkedList_Stack
    {
        private MyLinkedList? linkedList;
        private Node? top;
        private Node? bottom;
        public int Length { get; private set; }

        public LinkedList_Stack() {}

        public LinkedList_Stack(params int[] input)
        {
         linkedList = new MyLinkedList(input);
         this.Update();
        }

        private void Update()
        {
          bottom = linkedList.Head;
          top = linkedList.Tail;
          Length = linkedList.Length;
        }

        public void Push(int value)
        {
         if (linkedList == null)
            linkedList = new MyLinkedList(value);
         else
            linkedList.Append(value);

         this.Update();
         
        }

        public int Peak()
        {
            if (bottom == null)
                throw new InvalidOperationException();

            return top.Value;
        }
        
        public void Pop()
        {
            if (Length == 0)
                throw new InvalidOperationException("Stack is empty");

            linkedList.Remove(Length - 1);
            this.Update();
        }
      
        public bool IsEmpty()
        {
            if (Length == 0)
                return true;
            else
                return false;
        }
      

    }
}
