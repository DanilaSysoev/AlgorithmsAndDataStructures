namespace AlgorithmsAndDataStructures;

public class ArrayStack<T> : IStack<T>
{
    public ArrayStack()
    {
        data = new DynamicArray<T>();
        top = 0;
    }

    public void Pop()
    {
        if(IsEmpty)
            throw new InvalidOperationException("Stack is empty");
        --top;
        data.Remove();
    }

    public void Push(T value)
    {
        data.Add(value);
        ++top;
    }

    public int Size => data.Size;

    public T Top()
    {
        if(IsEmpty)
            throw new InvalidOperationException("Stack is empty");
        return data[top - 1];
    }

    public bool IsEmpty => top == 0;

    private readonly DynamicArray<T> data;
    private int top;
}
