using System;

namespace AlgorithmsAndDataStructures;

public class LinkedListQueue<T> : IQueue<T>
{
    public LinkedListQueue()
    {
        data = new DoubleLinkedList<T>();
    }

    public int Size => data.Size;

    public bool IsEmpty => data.IsEmpty;

    public void Dequeue()
    {
        if(IsEmpty)
            throw new InvalidOperationException("Queue is empty");

        data.Delete(data.Head);
    }

    public void Enqueue(T value)
    {
        data.AddTail(value);
    }

    public T Head()
    {
        if(IsEmpty)
            throw new InvalidOperationException("Queue is empty");

        return data.Head.Data!;
    }

    private readonly DoubleLinkedList<T> data;
}
