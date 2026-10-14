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
