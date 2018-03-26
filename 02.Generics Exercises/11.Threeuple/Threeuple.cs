using System.Net.Http.Headers;

public class Threeuple<TKey, TValue1, TValue2> : Tuple<TKey, TValue1>
{
    private TValue2 item3;
    
    public TValue2 Item3
    {
        get { return item3; }
    }

    public Threeuple(TKey item1, TValue1 item2, TValue2 item3)
        :base(item1, item2)
    {
        this.item3 = item3;
    }

    public override string ToString()
    {
        return $"{base.ToString()} -> {item3}";
    }
}