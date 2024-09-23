using System;

namespace AlgorithmsAndDataStructures;

public class ArrayQueue<T> : IQueue<T>
{
    public ArrayQueue(int size)
    {
        data = new DynamicArray<T>(size);
        this.size = 0;
        head = 0;
        tail = 0;
    }

    public int Size => size;

    public bool IsEmpty => size == 0;

    public void Dequeue()
    {
        if(IsEmpty)
            throw new InvalidOperationException("Queue is empty");

        ++head;
        if(head == data.Size)
            head = 0;

        --size;
    }

    public void Enqueue(T value)
    {
        if(size == data.Size)
            throw new InvalidOperationException("Queue overflow");

        data[tail] = value;
        ++tail;
        if(tail == data.Size)
            tail = 0;

        ++size;
    }

    public T Head()
    {
        if(IsEmpty)
            throw new InvalidOperationException("Queue is empty");

        return data[head];
    }

    private readonly DynamicArray<T> data;

    private int size;
    private int head;
    private int tail;
}
