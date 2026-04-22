using MyLinkedListLib;
using System.Collections;

namespace MyStackLib;

public class MyStack<T> : IEnumerable<T>
{
    private MyLinkedList<T> _list = new MyLinkedList<T>();

    public int Count
    {
        get
        {
            return _list.Count;
        }
    }

    public void Push(T item)
    {
        _list.AddFirst(item);
    }

    public T Pop()
    {
        T Value = _list.Head.Value;
        _list.RemoveFirst();
        return Value;
    }

    public T Peek()
    {
        if (_list.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return _list.Head.Value;
    }

    public IEnumerator<T> GetEnumerator()
    {
        MyLinkedListNode<T> current = _list.Head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
