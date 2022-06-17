// See https://aka.ms/new-console-template for more information
Console.WriteLine("Give the Amount");
var change = new Change();
var changeInput = Console.ReadLine();
int changeValue = 0;
var result = int.TryParse(changeInput, out changeValue);
int[] coinNumber = new int[3];
if(result)
{
    int[] coin = new int[]{10,5,2};
    int count = 0;
    for (int i = 0; i < coin.Length; i++)
    {
        count = changeValue / coin[i];
        if(count != 0)
        {
            coinNumber[i] = count;
            changeValue %= coin[i];
        }
    }
    change.coin2 = coinNumber[2];
    change.bill5 = coinNumber[1];
    change.bill10 = coinNumber[0];

    Console.WriteLine(change.ToString());
}
