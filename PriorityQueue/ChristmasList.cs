namespace PriorityQueue;

public class ChristmasList
{
  private readonly PriorityQueue<Child, int> queue;
  private readonly Queue<Child> simpleQueue;
  private readonly Func<Child, int> _priorityCalculation;

  public ChristmasList(Func<Child, int> priorityCalculation)
  {

    queue = new PriorityQueue<Child, int>();
    simpleQueue = new Queue<Child>();
    _priorityCalculation = priorityCalculation;
  }

  public void Add(Child child)
  {
    int priority = _priorityCalculation(child);
    queue.Enqueue(child, priority);
    simpleQueue.Enqueue(child);
  }

  public Child Get()
  {
    return queue.Dequeue();
  }

  public Child GetSimple()
  {
    return simpleQueue.Dequeue();
  }

  public PriorityQueue<Child, int> GetPriorityQueue()
  {
    return queue;
  }

  public Queue<Child> GetQueue()
  {
    return simpleQueue;
  }

 

}