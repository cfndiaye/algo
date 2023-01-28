using System.Timers;
public class UtilityTimer
{
   public  void TestTimer1(object sender, ElapsedEventArgs e)
    {
      System.Console.WriteLine(DateTime.UtcNow.ToString());
    }

    public  void TestTimer2(object sender, System.Timers.ElapsedEventArgs e)
    {
      System.Console.WriteLine(DateTime.UtcNow.ToString());
    }
    
  
}