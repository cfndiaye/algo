
public class Program
{
  public static void Main(string[] args)
  {
      Console.WriteLine("Testing timer");
      System.Timers.Timer timer = new System.Timers.Timer(3000);
      UtilityTimer utilityTimer = new UtilityTimer();


      timer.Elapsed += utilityTimer.TestTimer1;
      timer.Elapsed += utilityTimer.TestTimer2;

      timer.Start();

      Console.ReadLine();
  }


   
}