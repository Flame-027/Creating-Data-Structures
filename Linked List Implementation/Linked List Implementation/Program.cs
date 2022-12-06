using Linked_List_Implementation;
class Program
{
    static void Main()
    {
        MyLinkedList linkedList = new(1,2,3,4,5);
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

        Console.WriteLine();
        linkedList.Reverse();
        linkedList.Print();

        Console.WriteLine();
        Console.WriteLine();

        MyDoubleLinkedList myDoubleLinkedList = new(1,2,3,4,5);
        myDoubleLinkedList.Remove(4);
        myDoubleLinkedList.Print();
     
    }
}