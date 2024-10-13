namespace AlgorithmsAndDataStructures;

public interface ITree<TKey, TData> where TKey : IComparable<TKey>
{
    int Size { get; }

    TData? Get(TKey key);
    void Add(TKey key, TData data);

    TKey? Next(TKey key);
    TKey? Previous(TKey key);

    TKey? Min();
    TKey? Max();

    void Remove(TKey key);
}
