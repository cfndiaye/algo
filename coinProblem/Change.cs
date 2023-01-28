public class Change
{
    public int coin2 { get; set; }
    public int bill5 { get; set; }
    public int bill10 { get; set; }

    public const int c2 = 2;
    public const int c5 = 5;
    public const int c10 = 10;

    public Change(int value)
    {
        Changer(value);
    }

    public override string ToString()
    {
        return $"Change are: {coin2} * 2 + {bill5} * 5 + {bill10} * 10 = {coin2 * 2 + bill5 * 5 + bill10 * 10}";
    }


    public void Changer(int value)
    {
        int[] coinNumber = new int[3];
        int[] coin = new int[] { c10, c5, c2 };
        int count = 0;
        for (int i = 0; i < coin.Length; i++)
        {
            count = value / coin[i];
            if (count != 0)
            {
                coinNumber[i] = count;
                value %= coin[i];
            }
        }
        coin2 = coinNumber[2];
        bill5 = coinNumber[1];
        bill10 = coinNumber[0];

    }

}