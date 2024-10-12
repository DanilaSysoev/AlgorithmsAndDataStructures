using System;

namespace AlgorithmsAndDataStructures;

public class ArrayDequeue<T> : IDequeue<T>
{
    public int Size => size;

    public bool IsEmpty => size == 0;

    public ArrayDequeue(int capacity)
    {
        data = new DynamicArray<T>(capacity);
    }

    public T Back()
    {
        if(IsEmpty)
            throw new InvalidOperationException(DEQUEUE_IS_EMPTY);

        return data[back];
    }

    public T Front()
    {
        if(IsEmpty)
            throw new InvalidOperationException(DEQUEUE_IS_EMPTY);
        
        return data[front];
    }

    public void PopBack()
    {
        if(IsEmpty)
            throw new InvalidOperationException(DEQUEUE_IS_EMPTY);
        
        --back;
        if(back < 0)
            back = data.Size - 1;
        --size;
        
        if(IsEmpty)
            front = back = 0;
    }

    public void PopFront()
    {
        if(IsEmpty)
            throw new InvalidOperationException(DEQUEUE_IS_EMPTY);
        
        ++front;
        if(front == data.Size - 1)
            front = 0;
        --size;

        if(IsEmpty)
            front = back = 0;
    }

    public void PushBack(T value)
    {
        if(size == data.Size)
            throw new InvalidOperationException("Dequeue is full");
        if(!IsEmpty)
            ++back;
        if(back == data.Size - 1)
            front = 0;
        ++size;
        data[back] = value;
    }

    public void PushFront(T value)
    {
        if(size == data.Size)
            throw new InvalidOperationException("Dequeue is full");
        if(!IsEmpty)
            --front;
        if(front < 0)
            front = data.Size - 1;
        ++size;
        data[front] = value;
    }

    private readonly DynamicArray<T> data;
    private int front = 0;
    private int back = 0;
    private int size = 0;

    private const string DEQUEUE_IS_EMPTY = "Dequeue is empty";
}
