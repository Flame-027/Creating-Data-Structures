
namespace Linked_List_Implementation
{
    public class Node<T>
    {
      public T Value { get; set; }
      public Node<T>? Next { get; set; }

      public Node(T input)
      {
        this.Value = input;
      }
    }

}
