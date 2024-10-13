namespace AlgorithmsAndDataStructures;

public class BinaryTreeNode<TKey, TData> where TKey : IComparable<TKey>
{
    public TKey Key { get; internal set; }
    public TData? Data { get; set; }

    public BinaryTreeNode<TKey, TData>? Left { get; internal set; }
    public BinaryTreeNode<TKey, TData>? Right { get; internal set; }

    public BinaryTreeNode(TKey key)
    {
        Key = key;
    }
    public BinaryTreeNode(TKey key, TData data)
    {
        Key = key;
        Data = data;
    }
    public BinaryTreeNode(
        TKey key,
        TData data,
        BinaryTreeNode<TKey, TData>? left,
        BinaryTreeNode<TKey, TData>? right
    )
    {
        Key = key;
        Data = data;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree<TKey, TData> : ITree<TKey, TData>
    where TKey : IComparable<TKey>
{
    public int Size { get; private set; }
    public BinaryTreeNode<TKey, TData>? Root { get; private set; }

    public BinarySearchTree()
    {
        Size = 0;
    }

    public void Add(TKey key, TData data)
    {
        Root = AddRec(Root, key, data);
    }
    private BinaryTreeNode<TKey, TData> AddRec(
        BinaryTreeNode<TKey, TData>? current,
        TKey key,
        TData data
    )
    {
        if(current is null)
        {
            ++Size;
            return new BinaryTreeNode<TKey, TData>(key, data);
        }

        if(current.Key.CompareTo(key) == 0)
            current.Data = data;
        else if(current.Key.CompareTo(key) > 0)
            current.Left = AddRec(current.Left, key, data);
        else
            current.Right = AddRec(current.Right, key, data);
        return current;
    }

    public TData? Get(TKey key)
    {
        return GetRec(Root, key);
    }

    private TData? GetRec(BinaryTreeNode<TKey, TData>? current, TKey key)
    {
        if(current is null)
            return default;

        if(current.Key.CompareTo(key) == 0)
            return current.Data;
        else if(current.Key.CompareTo(key) > 0)
            return GetRec(current.Left, key);
        return GetRec(current.Right, key);
    }

    public TKey? Max()
    {
        return MaxRec(Root);
    }
    private TKey? MaxRec(BinaryTreeNode<TKey, TData>? current)
    {
        if(current is null)
            return default;
        if(current.Right is null)
            return current.Key;
        return MaxRec(current.Right);
    }

    public TKey? Min()
    {
        return MinRec(Root);
    }
    private TKey? MinRec(BinaryTreeNode<TKey, TData>? current)
    {
        if(current is null)
            return default;
        if(current.Left is null)
            return current.Key;
        return MinRec(current.Left);
    }

    public TKey? Next(TKey key)
    {
        var current = Root;
        TKey? result = default;

        while(current is not null)
        {
            if(current.Key.CompareTo(key) > 0)
            {
                result = current.Key;
                current = current.Left;
            }
            else
                current = current.Right;
        }
        return result;
    }

    public TKey? Previous(TKey key)
    {
        var current = Root;
        TKey? result = default;

        while(current is not null)
        {
            if(current.Key.CompareTo(key) < 0)
            {
                result = current.Key;
                current = current.Right;
            }
            else
                current = current.Left;
        }
        return result;
    }

    public void Remove(TKey key)
    {
        Root = RemoveRec(Root, key);
    }

    private BinaryTreeNode<TKey, TData>? RemoveRec(
        BinaryTreeNode<TKey, TData>? current, TKey key
    )
    {
        if(current is null)
            return null;
        if(current.Key.CompareTo(key) == 0)
        {
            if(current.Left is null)
            {
                --Size;
                return current.Right;
            }
            if(current.Right is null)
            {
                --Size;
                return current.Left;
            }
            var min = current.Right;
            while(min.Left is not null)
                min = min.Left;
            current.Key = min.Key;
            current.Data = min.Data;
            current.Right = RemoveRec(current.Right, min.Key);
        }
        else if(current.Key.CompareTo(key) > 0)
            current.Left = RemoveRec(current.Left, key);
        else
            current.Right = RemoveRec(current.Right, key);
        return current;
    }
}
