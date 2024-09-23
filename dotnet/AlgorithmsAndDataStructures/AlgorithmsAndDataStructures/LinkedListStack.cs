using System;

namespace AlgorithmsAndDataStructures;

public class LinkedListStack<T> : IStack<T>
{
    public LinkedListStack()
    {
        data = new DoubleLinkedList<T>();
    }

    public int Size => data.Size;

    public bool IsEmpty => data.Size == 0;

    public void Pop()
    {
        if(IsEmpty)
            throw new InvalidOperationException("Stack is empty");
        data.Delete(data.Tail);
    }

    public void Push(T value)
    {
        data.AddTail(value);
    }

    public T Top()
    {
        if(IsEmpty)
            throw new InvalidOperationException("Stack is empty");
        return data.Tail.Data!;
    }

    private readonly DoubleLinkedList<T> data;
}
