using Linked_List_Implementation;
class Program
{
    static void Main()
    {
  // To see how the LinkedList works go to the LinkedList libary implementation directory.

        MyLinkedList<int> linkedList = new(1,2,3,4,5);
        linkedList.Print();
          
        linkedList.Append(6);
        linkedList.Prepend(0);
        linkedList.Print();
        
        linkedList.Insert(2, 9);
        linkedList.Print();

        linkedList.Insert(8, 12);
        linkedList.Print();

        linkedList.Remove(2);
        linkedList.Print();

        //Console.WriteLine();
        //linkedList.Reverse();
        //linkedList.Print();

        Console.WriteLine();
        Console.WriteLine();

        MyDoubleLinkedList<int> myDoubleLinkedList = new(1,2,3,4,5);
        myDoubleLinkedList.Remove(4);
        myDoubleLinkedList.Print();
     
  // To see how the LinkedList works go to the LinkedList libary implementation directory.

    }
}