public class Change
{
    public int coin2 { get; set; }
    public int bill5 { get; set; }
    public int bill10 { get; set; }

    public override string ToString()
    {
        return $"Change are: {coin2} * 2 + {bill5} * 5 + {bill10} * 10 = {coin2*2 + bill5*5 + bill10*10}";
    }
}