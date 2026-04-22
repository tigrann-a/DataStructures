using MyLinkedListLib;
using System.Collections;

namespace MyQueueLib;

public class MyQueue<T> : IEnumerable<T>
{
    private MyLinkedList<T> _items = new MyLinkedList<T>();
    public int Count
    {
        get
        {
            return _items.Count;
        }
    }

    public void Enqueue(T item)
    {
        _items.AddLast(item);
    }

    public T Dequeue()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty!");
        }

        T value = _items.Head.Value;
        _items.RemoveFirst();

        return value;
    }

    public T Peek()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty!");
        }

        return _items.Head.Value;
    }

    public void Clear()
    {
        _items.Clear();
    }
    public IEnumerator<T> GetEnumerator()
    {
        MyLinkedListNode<T> current = _items.Head;
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

