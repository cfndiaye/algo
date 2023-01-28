// See https://aka.ms/new-console-template for more information
using PriorityQueue;

int age = 10;

var chrismasList = new ChristmasList(GetPriority);

for (int i = 0; i < 8; i++)
{
    
    chrismasList.Add(new Child(age + i));
    
}


var random = new Random();

int GetPriority(Child child)
{
    var goodDeed = 0;
    var badDeed = 0;

    for (int i = 0; i < child.Deeds.Count; i++)
    {
        var deed = child.Deeds[i];
        if (deed.GetType() == typeof(GoodDeed))
        {
            goodDeed++;
        }
        if (deed.GetType() == typeof(BadDeed))
        {
            badDeed++;
        }
    }
    var result = goodDeed > badDeed ? goodDeed : badDeed;
    return result;
}


var queue = chrismasList.GetPriorityQueue();

var count = queue.Count;
System.Console.WriteLine($"item in queue: {count}");

for (int i = 0; i < count; i++)
{
    var child = chrismasList.Get();
    var childFromSimpleQueue = chrismasList.GetSimple();
    System.Console.WriteLine($"PQ - {child.ToString()} <-----> SP - {childFromSimpleQueue.ToString()}");
}
