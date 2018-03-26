using System.Net.Http.Headers;

public class Tuple<TKey, TValue>
{
    private TKey item1;
    private TValue item2;

    public TKey Item1
    {
        get { return item1; }
    }
    public TValue Item2
    {
        get { return item2; }
    }

    public Tuple(TKey item1, TValue item2)
    {
        this.item1 = item1;
        this.item2 = item2;
    }

    public override string ToString()
    {
        return $"{item1} -> {item2}";
    }
}