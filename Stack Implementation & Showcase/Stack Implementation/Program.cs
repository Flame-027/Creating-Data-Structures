namespace Stack_Implementation
{ 
  class Program
  {
    static void Main()
    {
     LinkedList_Stack linkListStack = new();
     linkListStack.Push(1);
     linkListStack.Push(2);
     linkListStack.Push(3);

     Console.WriteLine(linkListStack.Peak());

     linkListStack.Pop();
     linkListStack.Pop();

     Console.WriteLine(linkListStack.IsEmpty());
     linkListStack.Pop();

     Console.WriteLine(linkListStack.IsEmpty());
     Console.WriteLine();
     Console.WriteLine();
     


     Array_Stack arrayStack = new();
     arrayStack.Push("Tom");
     arrayStack.Push("Rob");
     arrayStack.Push("Bob");

     Console.WriteLine(arrayStack.Peak());

     arrayStack.Pop();
     arrayStack.Pop();

     Console.WriteLine(arrayStack.IsEmpty());

     arrayStack.Pop();

     Console.WriteLine(arrayStack.IsEmpty());
    }

  }
}