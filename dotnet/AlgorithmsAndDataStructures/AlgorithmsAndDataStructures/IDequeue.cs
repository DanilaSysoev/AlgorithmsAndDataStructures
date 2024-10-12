namespace AlgorithmsAndDataStructures;

public interface IDequeue<T>
{
    int Size { get; }
    bool IsEmpty { get; }

    T Front();
    T Back();

    void PushFront(T value);
    void PushBack(T value);

    void PopFront();
    void PopBack();
}
