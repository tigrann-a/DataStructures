using System.Collections;

namespace MyQueueWithArrayLib;

public class MyQueueWithArray<T> : IEnumerable<T>
{
    private T[] _list = new T[0];

    public int Count
    {
        get
        {
            return _list.Length;
        }
    }

    public void Enqueue(T item)
    {
        T[] newList = new T[_list.Length + 1];
        for(int i = 0; i < _list.Length; i++)
        {
            newList[i] = _list[i];
        }
        newList[newList.Length - 1] = item;
        _list = newList;
    }

    public T Dequeue()
    {
        if (_list.Length == 0)
        {
            throw new InvalidOperationException("The queue is empty!");
        }

        T Value = _list[0];
        T[] newList = new T[_list.Length - 1];
        for (int i = 0; i < newList.Length; i++)
        {
            newList[i] = _list[i + 1];
        }
        _list = newList;

        return Value;
    }

    public T Peek()
    {
        if (_list.Length == 0)
        {
            throw new InvalidOperationException("The queue is empty!");
        }

        return _list[0];
    }

    public void Clear()
    {
        _list = new T[0];
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _list.Length; i++)
        {
            yield return _list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
