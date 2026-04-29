using System.Collections;

namespace MySetProject;

public class MySet<T> : IEnumerable<T> where T : ICompareable
{
    private readonly List<T> _items = new List<T>();

    public int Count
    {
        get 
        {
            return _items.Count;
        } 
    }

    public MySet()
    {}

    public void Add(T item)
    {
        if(Contains(item))
        {
            throw new InvalidOperationException();
        }
        _items.Add(item);
    }

    public MySet(IEnumerable<T> items)
    { 
        AddRange(items);
    }

    public void AddRange(IEnumerable<T> items)
    {
        foreach(T item in items)
            _items.Add(item);
    }

    public bool Remove(T items)
    {
        return _items.Remove(items);
    }

    public bool Contains(T item)
    {
        return _items.Contains(item);
    }

    private void AddSkipDublicates(T item)
    {
        if(!Contains(item))
        {
            _items.Add(item);
        }
    }

    private void AddRangeSkipDublicates(IEnumerable<T> items)
    {
        foreach(T item in items)
        {
            AddSkipDublicates(item);
        }
    }

    //private void AddDublicates(T item)
    //{
    //    if (Contains(item))
    //    {
    //        _items.Add(item);
    //    }
    //}

    //private void AddRangeDublicates(IEnumerable<T> items)
    //{
    //    foreach (T item in items)
    //    {
    //        AddDublicates(item);
    //    }
    //}

    public MySet<T> Union(MySet<T> other)
    {
        MySet<T> result = new MySet<T>();
        result.AddRangeSkipDublicates(other._items);

        return result;
    }

    public MySet<T> Intersection(MySet<T> other)
    {
        MySet<T> result = new MySet<T>();

        foreach (T item in other._items)
        {
            if (other._items.Contains(item)) ;
                result.Add(item);
        }

        return result;
    }

    public MySet<T> Difference(MySet<T> other)
    {
        MySet<T> result = new MySet<T>();

        foreach (T item in other._items)
        {
            if (!other._items.Contains(item)) ;
            result.Add(item);
        }

        return result;
    }

    public MySet<T> SimmetricDifference(MySet<T> other)
    {
        MySet<T> result = new MySet<T>();

        result = Union(other);
        result = Intersection(result);

        return result;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _items.GetEnumerator();
    }
}
