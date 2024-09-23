namespace AlgorithmsAndDataStructures;

public interface IStack<T>
{
    T Top();
    void Pop();
    void Push(T value);
    int Size { get; }
    bool IsEmpty { get; }
}
