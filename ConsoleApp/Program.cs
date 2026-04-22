using MyLinkedListLib;
using MyQueueLib;
using MyStackLib;

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
MyStack<int> list = new MyStack<int>();

list.Push(3);
list.Push(4);
list.Push(18);
list.Push(33);

foreach(var item in list)
    Console.WriteLine(item);
#endregion