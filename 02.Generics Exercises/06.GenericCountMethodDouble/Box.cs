using System;

public class Box<T>
    where T : IComparable<T>
{
    private T value;

    public T Value
    {
        get => this.value;
        private set => this.value = value;
    }

    public Box(T value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        return $"{value.GetType().FullName}: {value}";
    }
}