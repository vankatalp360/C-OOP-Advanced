using System;

public class Scale<T>
    where T : IComparable<T>
{
    private T left;
    private T right;

    public Scale(T left, T right)
    {
        this.left = left;
        this.right = right;
    }

    public T GetHeavier()
    {
        switch (left.CompareTo(right))
        {
            case -1: return right;
            case 1: return left;
            default: return default(T);
        }
    }
}