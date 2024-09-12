namespace AlgorithmsAndDataStructures;

public class DynamicArray<T>
{
    public int Size => size;

    public T this[int index]
    {
        get
        {
            if(index < 0 || index >= Size)
                throw new ArgumentOutOfRangeException("index");

            return data[index];
        }
        set
        {
            if(index < 0 || index >= Size)
                throw new ArgumentOutOfRangeException("index");
            
            data[index] = value;
        }
    }

    public DynamicArray()
    {
        data = new T[DefaultCapacity];
        capacity = DefaultCapacity;
        size = 0;
    }

    public void Add(T value)
    {
        if(Size == capacity)
            Resize(capacity * ResizeCoefficient);
        data[size++] = value;
    }

    public void Remove()
    {
        if(Size == 0)
            throw new InvalidOperationException("Array is empty");
        size--;
        if(size * ResizeCoefficient * ResizeCoefficient <= capacity)
            Resize(capacity / ResizeCoefficient);
    }

    private void Resize(int newCapacity)
    {
        T[] nData = new T[newCapacity];
        Array.Copy(data, nData, size);
        capacity = newCapacity;
        data = nData;
    }

    private T[] data;
    private int capacity;
    private int size;

    private const int DefaultCapacity = 16;
    private const int ResizeCoefficient = 2;
}