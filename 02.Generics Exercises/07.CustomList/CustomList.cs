using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CustomList<T> : IEnumerable<T>
    where T : IComparable<T>
{
    private List<T> list;

    public CustomList()
    {
        list = new List<T>();
    }

    public void Add(T element) => list.Add(element);

    public T Remove(int index)
    {
        var element = list[index];
        list.RemoveAt(index);
        return element;
    }

    public bool Contains(T element) => list.Contains(element);

    public void Swap(int firstIndex, int secondIndex)
    {
        var firstElement = list[secondIndex];
        list[secondIndex] = list[firstIndex];
        list[firstIndex] = firstElement;
    }

    public int CountGreaterThan(T element)
    {
        var counter = 0;

        foreach (var item in list)
        {
            counter += item.CompareTo(element) > 0 ? 1 : 0;
        }

        return counter;
    }

    public T Max() => list.OrderByDescending(e => e).First();
    public T Min() => list.OrderBy(e => e).First();
    public IEnumerator<T> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return list.GetEnumerator();
    }
}