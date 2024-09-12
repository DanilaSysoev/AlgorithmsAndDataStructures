namespace AlgorithmsAndDataStructures;

public class Node<T>
{
    public T? Data { get; set; }

    public Node<T>? Next { get; set; }
    public Node<T>? Previous { get; set; }

    public Node(
        T? data = default,
        Node<T>? next = null,
        Node<T>? previous = null
    )
    {
        Data = data;
        Next = next;
        Previous = previous;
    }
}

public class DoubleLinkedList<T>
{
    public Node<T> Head => dummy.Next!;
    public Node<T> Tail => dummy.Previous!;
    public int Size { get; private set; }

    public DoubleLinkedList()
    {
        dummy = new Node<T>();
        dummy.Next = dummy;
        dummy.Previous = dummy;

        Size = 0;
    }

    public T? this[int index]
    {
        get
        {
            if(index < 0 || index >= Size)
                throw new ArgumentOutOfRangeException("index");
            Node<T> worker = FindNode(index);
            return worker.Data;
        }
        set
        {
            if (index < 0 || index >= Size)
                throw new ArgumentOutOfRangeException("index");
            Node<T> worker = FindNode(index);
            worker.Data = value;
        }
    }

    public Node<T> AddHead(T? value)
    {
        return AddAfter(dummy, value);
    }

    public Node<T> AddAfter(Node<T> dummy, T? value)
    {
        Node<T> node = new Node<T>(value, dummy.Next, dummy);
        dummy.Next!.Previous = node;
        dummy.Next = node;
        ++Size;
        return node;
    }

    public Node<T> AddTail(T? value)
    {
        return AddBefore(dummy, value);
    }

    public Node<T> AddBefore(Node<T> dummy, T? value)
    {
        Node<T> node = new Node<T>(value, dummy, dummy.Previous);
        dummy.Previous!.Next = node;
        dummy.Previous = node;
        ++Size;
        return node;
    }

    public void Delete(Node<T> node)
    {
        node.Previous!.Next = node.Next;
        node.Next!.Previous = node.Previous;
    }

    private Node<T> FindNode(int index)
    {
        int pos = 0;
        var worker = Head;
        while (pos < index)
        {
            worker = worker.Next!;
            pos++;
        }

        return worker;
    }

    private readonly Node<T> dummy;
}
