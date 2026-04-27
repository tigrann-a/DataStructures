using System;
using System.Collections;

namespace MyBinaryTreeLib;

public class MyBinaryTree<T> : IEnumerable<T> where T : IComparable<T>
{
    private MyBinaryTreeNode<T> _root;
    private int _count;

    public bool Contains(T item)
    {
        return FindWithParent(item, out MyBinaryTreeNode<T> parent) != null;
    }

    private MyBinaryTreeNode<T> FindWithParent(T value, out MyBinaryTreeNode<T> parent)
    {
        MyBinaryTreeNode<T> current = _root;
        parent = null;

        while (current != null)
        {
            int result = current.CompareTo(value);
            if (result > 0)
            {
                parent = current;
                current = current.Left;
            }
            else if (result < 0)
            {
                parent = current;
                current = current.Right;
            }
            else
                break;
        }

        return current;
    }

    public void Add(T item)
    {
        _root = Add(_root, item);
    }

    public MyBinaryTreeNode<T> Add(MyBinaryTreeNode<T> current, T item)
    {
        
        if (current == null)
        {
            current = new MyBinaryTreeNode<T>(item);
            return current;
        }

        int compResult = item.CompareTo(current.Value);

        if (compResult < 0)
        {
            current.Left = Add(current.Left, item);
        }

        if (compResult > 0)
        {
            current.Right = Add(current.Right, item);
        }

        return current;
    }

    #region PreOrderTraversal

    //public delegate void Action<T>(T item);
    //public void PreOrderTraversal(Action<T> action)
    //{
    //    PreOrderTraversal(action, _root);
    //}

    //private void PreOrderTraversal(Action<T> action, MyBinaryTreeNode<T> root)
    //{
    //    if (root == null)
    //    {
    //        return;
    //    }
    //    action(root.Value);
    //    PreOrderTraversal(action, root.Left);
    //    PreOrderTraversal(action, root.Right);
    //}
    #endregion

    #region In-Order Traversal

    public void InOrderTraversal(Action<T> action)
    {
        InOrderTraversal(action, _root);
    }

    private void InOrderTraversal(Action<T> action, MyBinaryTreeNode<T> root)
    {
        if (root == null)
        {
            return;
        }

        InOrderTraversal(action, root.Left);
        action(root.Value);
        InOrderTraversal(action, root.Right);
    }

    #endregion

    //private IEnumerator<T>? PreOrderTraversal(Action<T> action, MyBinaryTreeNode<T> root)
    //{
    //    if (root == null)
    //    {
    //        return null;
    //    }

    //    InOrderTraversal(action, root.Left);
    //    action(root.Value);
    //    InOrderTraversal(action, root.Right);
    //}

    public IEnumerator<T> GetEnumerator()
    {
        return InOrderEnumerate(_root).GetEnumerator();
    }

    private IEnumerable<T> InOrderEnumerate(MyBinaryTreeNode<T> node)
    {
        if(node == null)
            yield break;

        foreach (var item in InOrderEnumerate(node.Left))
            yield return item;
        
        yield return node.Value;

        foreach (var item in InOrderEnumerate(node.Right))
            yield return item;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
