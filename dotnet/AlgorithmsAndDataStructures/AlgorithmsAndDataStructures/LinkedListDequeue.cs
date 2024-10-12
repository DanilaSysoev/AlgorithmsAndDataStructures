namespace AlgorithmsAndDataStructures;

public class LinkedListDequeue<T> : IDequeue<T>
{
    public int Size => data.Size;

    public bool IsEmpty => data.IsEmpty;

    public T Back()
    {
        if(IsEmpty)
            throw new InvalidOperationException(DEQUEUE_IS_EMPTY);

        return data.Tail.Data!;
    }

    public T Front()
    {
        if(IsEmpty)
            throw new InvalidOperationException(DEQUEUE_IS_EMPTY);

        return data.Head.Data!;
    }

    public void PopBack()
    {
        if(IsEmpty)
            throw new InvalidOperationException(DEQUEUE_IS_EMPTY);

        data.Delete(data.Tail);
    }

    public void PopFront()
    {
        if(IsEmpty)
            throw new InvalidOperationException(DEQUEUE_IS_EMPTY);

        data.Delete(data.Head);
    }

    public void PushBack(T value)
    {
        data.AddTail(value);
    }

    public void PushFront(T value)
    {
        data.AddHead(value);
    }

    private readonly DoubleLinkedList<T> data = new();

    private const string DEQUEUE_IS_EMPTY = "Dequeue is empty";
}
