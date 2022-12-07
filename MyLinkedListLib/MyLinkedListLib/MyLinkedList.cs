using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Implementation
{
    public class MyLinkedList
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public  int Length { get; private set; }


        public MyLinkedList (params int[] input)
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
                currentNode.Next = new Node(input[i]);
                currentNode = currentNode.Next;
                Length++;

                if (i == input.Length - 1)
                {
                    Tail = currentNode;
                }
            }
           if (Tail == null)
           Tail = Head;
        }

        public void Append(int input)
        {
            Tail.Next = new Node(input);
            Tail = Tail.Next;   
            Length++;
        }

        public void Prepend(int input)
        {
           Node newHead = new Node(input);
           newHead.Next = Head;
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
            if (index > Length)
                throw new InvalidOperationException("Index is out of bounds");

            else if (index == -1)
                this.Prepend(value);

            else if (index == Length - 1)
                this.Append(value);
            else
            {
                var leader = this.TravereseToIndex(index - 1);
                Node newNode = new(value);
                newNode.Next = leader.Next;
                leader.Next = newNode; 

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
               }
            }
            Length--;
        }

        private Node TravereseToIndex(int index)
        {
            if (index > Length - 1 || index < 0)
                throw new InvalidOperationException("Index is out of bounds");

              var currentNode = Head;
              var currentIndex = 0;

               while (currentIndex != index)
               {
                 currentNode = currentNode.Next;
                 currentIndex++;
               }
               return currentNode;
        }

        //public void Reverse()
        //{
        //    if (Head == null)
        //        throw new InvalidOperationException();

        //    else if (Head.Next == null) {}

        //    else
        //    {
        //        var currentNode = Head;
        //        var index = 0;
        //        int[] reversed = new int[Length];

        //        while (currentNode != null)
        //        {
        //            var placement = Length - 1 - index;
        //            reversed[placement] = currentNode.Value;

        //            currentNode = currentNode.Next;
        //            index++;
        //        }
        //        this.CreateList(reversed);
        //    }
            


        //}
    }
}
