using MyLinkedListLib;
using MyQueueLib;
using MyStackLib;
using MyStackWithArrayLib;
using MyQueueWithArrayLib;
using MyBinaryTreeLib;

#region MyLinkedList

//MyLinkedList<int> list = new MyLinkedList<int>();

//list.Add(3);
//list.Add(4);
//list.Add(18);
//list.Add(33);

// using FOREACH
//foreach(var item in list)
//    Console.WriteLine(item);

// using WHILE
//MyLinkedListNode<int> current = list.Head;

//while(current != null)
//{
//    Console.WriteLine(current.Value);
//    current = current.Next;
//}

#endregion

#region MyQueue
//MyQueue<int> items = new MyQueue<int>();

//items.Enqueue(3);
//items.Enqueue(4);
//items.Enqueue(18);
//items.Enqueue(33);

//foreach(var item in list)
//    Console.WriteLine(item);

#endregion

#region MyStack
//MyStack<int> list = new MyStack<int>();

//list.Push(3);
//list.Push(4);
//list.Push(18);
//list.Push(33);

//foreach(var item in list)
//    Console.WriteLine(item);
#endregion

#region MyStackWithArray
//MyStackWitհArray<int> list = new MyStackWitհArray<int>();

//list.Push(3);
//list.Push(4);
//list.Push(18);
//list.Push(33);

//foreach (int i in list)
//    Console.WriteLine(i);

//list.Pop();

//foreach (int i in list)
//    Console.WriteLine(i);

//int lastElem = list.Peek();
//Console.WriteLine(lastElem);

//int elem = list.Pop();
//Console.WriteLine(elem);

//foreach (int i in list)
//    Console.WriteLine(i);

//list.Clear();

//foreach (int i in list)
//    Console.WriteLine(i);
#endregion

#region MyQueueWithArray
//MyQueueWithArray<int> list = new MyQueueWithArray<int>();

//list.Enqueue(3);
//list.Enqueue(4);
//list.Enqueue(18);
//list.Enqueue(33);

//foreach (var item in list)
//    Console.WriteLine(item);

//list.Dequeue();

//Console.WriteLine("---");

//foreach (var item in list)
//    Console.WriteLine(item);

//int count = list.Count;

//Console.WriteLine(count);
#endregion

#region MyBinaryTree

MyBinaryTree<int> tree = new MyBinaryTree<int>();

tree.Add(3);
tree.Add(2);
tree.Add(4);

foreach (var item in tree)
{
    Console.WriteLine(item);
}

#endregion