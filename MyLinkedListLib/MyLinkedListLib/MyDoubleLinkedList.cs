using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Implementation
{
    public class MyDoubleLinkedList
    {
        public DoubleNode Head { get; private set; }
        public DoubleNode Tail { get; private set; }

        public  int Length { get; private set; }


        public MyDoubleLinkedList (params int[] input)
        {
            CreateList(input);
        }

        private void CreateList(int[] input)
        {
           if (input.Length == 0)
              throw new InvalidOperationException();

           Head = new(input[0]);
           Length++;

           var currentNode = Head;

            for (int i = 1; i < input.Length; i++)
            {
                var nextNode = new DoubleNode(input[i]);
                currentNode.Next = nextNode;
                nextNode.Previous = currentNode;

                currentNode = currentNode.Next;
                Length++;

                if (i == input.Length - 1)
                {
                    Tail = currentNode;
                    break;
                }
            }
           if (Tail == null)
           Tail = Head;
        }

        public void Append(int input)
        {
            var newTail = new DoubleNode(input);
            Tail.Next = newTail;
            newTail.Previous = Tail;
            Tail = newTail;   
            Length++;
        }

        public void Prepend(int input)
        {
           DoubleNode newHead = new DoubleNode(input);
           newHead.Next = Head;
           Head.Previous = newHead;
           Head = newHead;
           Length++;
        }


        public void Print()
        {
            var result = this.LinkedListToList();
            Console.WriteLine();
            foreach (var item in result)
            Console.Write(item + " ");

        }

        private List<int> LinkedListToList()
        {
            var currentNode = Head;

            if (Head == null)
                throw new InvalidOperationException();

            if (Head.Next == null)
                return new List<int> {Head.Value};

            List<int> result = new();

            while (currentNode != null)
            {
                result.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }

            return result;
        }

        public void Insert(int index, int value)
        {
            if (index > Length || index < -1)
                throw new InvalidOperationException("Index is out of bounds");

            else if (index == -1)
                this.Prepend(value);

            else if (index == Length)
                this.Append(value);
            else
            {
                DoubleNode newNode = new(value);
                var leader = this.TravereseToIndex(index - 1);
                var follower = leader.Next;

                leader.Next = newNode; 
                newNode.Previous = leader;
                newNode.Next = follower;
                follower.Previous = newNode; 

            }
            Length++;
        }

        public void Remove(int index)
        {
            if (index > Length - 1 || index < 0)
                throw new InvalidOperationException("Index is out of bounds");

             if (index == 0)
                Head = null;

             else
             {
                var leader = this.TravereseToIndex(index - 1);

                if(index == Length - 1)
                {
                leader.Next = null;
                this.Tail = leader;
                }
                else
                { 
                var follower = leader.Next.Next;
                leader.Next = follower;
                follower.Previous = leader;
                }
             } 
            Length--;
        }

        private DoubleNode TravereseToIndex(int index)
        {
            if (index > Length - 1 || index < 0)
                throw new InvalidOperationException("Index is out of bounds");

            var fromHead = (0 - index) * -1;
            var fromTail = Length - (index + 1);
            if (fromHead <= fromTail)
            {
              var currentNode = Head;
              var currentIndex = 0;

               while (currentIndex != index)
               {
                    currentNode = currentNode.Next;
                    currentIndex++;
               }
               return currentNode;
            }
            else
            {
              var currentNode = Tail;
              var currentIndex = Length - 1;

              while (currentIndex != index)
              {
                    currentNode = currentNode.Previous;
                    currentIndex--;
              }
              return currentNode;

            }


              
        }
    }
}
