using Linked_List_Implementation;

namespace Stack_Implementation
{
    public class LinkedList_Stack
    {
        private MyLinkedList? _linkedList;
        private Node? top;
        private Node? bottom;
        public int Length { get; private set; }

        public LinkedList_Stack() {}

        public LinkedList_Stack(params int[] input)
        {
         _linkedList = new MyLinkedList(input);
         this.Update();
        }

        private void Update()
        {
          top = _linkedList.Head;
          bottom = _linkedList.Tail;
          Length = _linkedList.Length;
        }

        public void Push(int value)
        {
         if (_linkedList == null)
            _linkedList = new MyLinkedList(value);
         else
            _linkedList.Prepend(value);

         this.Update();
         
        }

        public int Peak()
        {
            if (top == null)
                throw new InvalidOperationException();

            return top.Value;
        }
        
        public void Pop()
        {
            if (Length == 0)
                throw new InvalidOperationException("Stack is empty");

            _linkedList.Remove(0);
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
