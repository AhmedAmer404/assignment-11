#region Question1
//A generic class is a class that works with different data types using a type parameter
//Code reusability.
//Type safety.
//Reduce type casting.
//Work with different data types using the same class.
#endregion

#region Question2
class Container<T>
{
    private T item;

    public void Add(T value)
    {
        item = value;
    }

    public T Get()
    {
        return item;
    }
}
#endregion
#region Question 3
//Multiple type parameters mean using more than one type parameter in a generic class, allowing each parameter to represent a different data type.
class Pair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }

    public Pair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}
#endregion
