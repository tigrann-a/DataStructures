
namespace MyLinkedListLib;

public class MyLinkedListNode<T>
{
    public T Value { get; set; }
    public MyLinkedListNode<T> Next { get; set; }

    public MyLinkedListNode(T value)
    {
        Value = value;
    }

    public static implicit operator MyLinkedListNode<T>(MyLinkedList<T>? v)
    {
        throw new NotImplementedException();
    }
}