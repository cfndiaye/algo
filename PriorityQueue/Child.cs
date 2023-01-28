namespace PriorityQueue;

public class Child
{
    public bool HasSiblings { get; set; }
    public int Age { get; set; }
    public int GoodDeeds { get; set; } = 0;
    public int BadDeeds { get; set; } = 0;
    public List<Deed> Deeds { get; set; } = new List<Deed>();

    public Child(int age)
    {
        Age = age;
       
        var random = new Random();
        
        int n = 15;
        for (int i = 0; i < n; i++)
        {
            var r = random.Next(0, 15);

            if ((r & 2) == 0)
            {
                Deeds.Add(new GoodDeed());

            }
            else
            {
                Deeds.Add(new BadDeed());
            }

        }
        
        GoodDeeds = Deeds.Where(x => x.GetType() == typeof(GoodDeed)).Count();
        BadDeeds = Deeds.Where(x => x.GetType() == typeof(BadDeed)).Count();
    }

    public override string ToString()
    {
        return $"child age: {Age} - Deeds : {Deeds.Count} => GoodDeeds : {GoodDeeds}, BadDeeds : {BadDeeds}";
    }
}







