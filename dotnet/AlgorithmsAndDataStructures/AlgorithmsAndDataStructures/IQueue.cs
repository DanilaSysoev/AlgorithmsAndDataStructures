namespace AlgorithmsAndDataStructures;

public interface IQueue<T>
{
    T Head();
    void Dequeue();
    void Enqueue(T value);
    int Size { get; }
    bool IsEmpty { get; }
}
