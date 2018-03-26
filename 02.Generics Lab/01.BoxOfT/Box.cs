using System.Collections.Generic;

public class Box<T>
{
    private List<T> items;

    public IReadOnlyCollection<T> Items => items;

    public Box()
    {
        this.items = new List<T>();
    }

    public void Add(T element) => items.Add(element);

    public T Remove()
    {
        var element = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return element;
    }

    public int Count => items.Count;
}