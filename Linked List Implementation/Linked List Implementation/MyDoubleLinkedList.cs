using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Implementation
{
    public class MyDoubleLinkedList
    {
        DoubleNode head;
        DoubleNode tail;

        public  int Length { get; private set; }


        public MyDoubleLinkedList (params int[] input)
        {
            CreateList(input);
        }

        private void CreateList(int[] input)
        {
           if (input.Length == 0)
              throw new InvalidOperationException();

           head = new(input[0]);
           Length++;

           var currentNode = head;

                for (int i = 1; i < input.Length; i++)
                {
                    var nextNode = new DoubleNode(input[i]);
                    currentNode.Next = nextNode;
                    nextNode.Previous = currentNode;

                    currentNode = currentNode.Next;
                    Length++;
                    
                   if (i == input.Length - 1)
                   {
                    tail = currentNode;
                    break;
                   }
                }
        }

        public void Append(int input)
        {
            var newTail = new DoubleNode(input);
            tail.Next = newTail;
            newTail.Previous = tail;
            tail = newTail;   
            Length++;
        }

        public void Prepend(int input)
        {
           DoubleNode newHead = new DoubleNode(input);
           newHead.Next = head;
           head.Previous = newHead;
           head = newHead;
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
            var currentNode = head;

            if (head == null)
                throw new InvalidOperationException();

            if (head.Next == null)
                return new List<int> {head.Value};

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
            if (index > Length + 1 || index < -1)
                throw new InvalidOperationException("Index is out of bounds");

            else if (index == -1)
                this.Prepend(value);

            else if (index == Length + 1)
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
        }

        public void Remove(int index)
        {
            if (index > Length)
                throw new InvalidOperationException("Index is out of bounds");

            var leader = this.TravereseToIndex(index - 1);

            if(index == Length - 1)
            {
                leader.Next = null;
                this.tail = leader;
            }
            else
            { 
               var follower = leader.Next.Next;
               leader.Next = follower;
               follower.Previous = leader;
            }
           
        }

        private DoubleNode TravereseToIndex(int index)
        {
            if (index > Length)
                throw new InvalidOperationException("Index is out of bounds");

            var fromHead = (0 - index) * -1;
            var fromTail = Length - (index + 1);
            if (fromHead <= fromTail)
            {
              var currentNode = head;
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
              var currentNode = tail;
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
