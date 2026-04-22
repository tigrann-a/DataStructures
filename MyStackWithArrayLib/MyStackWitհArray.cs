using System.Collections;

namespace MyStackWithArrayLib;

public class MyStackWitհArray<T> : IEnumerable<T>
{
    private T[] _list = new T[0];

    public int Count
    {
        get
        {
            return _list.Length;
        }
    }

    public void Push(T item)
    {
        T[] newList = new T[_list.Length + 1];
        for (int i = 0; i < _list.Length; i++)
        {
            newList[i] = _list[i];
        }
        newList[newList.Length - 1] = item;
        _list = newList;
    }

    public T Pop()
    {
        if (_list.Length == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T Value = _list[_list.Length - 1];
        T[] newList = new T[_list.Length - 1];
        for (int i = 0; i < newList.Length; i++)
        {
            newList[i] = _list[i];
        }
        _list = newList;

        return Value;
    }

    public T Peek()
    {
        if(_list.Length == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T Value = _list[_list.Length - 1];
        
        return Value;
    }

    public void Clear()
    {
        _list = new T[0];
    }

    public IEnumerator<T> GetEnumerator()
    {
        for(int i = 0; i < _list.Length; i++)
        {
            yield return _list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
