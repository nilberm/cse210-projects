public class BreathingActivity : Activity
{

  public BreathingActivity() : base(startMsg: "Breathing Activity", description: "This simple breathing exercise can help you unwind and find inner peace by guiding you through slow, deliberate inhales and exhales. Quiet your thoughts and center your attention on your breath.")
  {
  }

  public void Run()
  {
    Console.Clear();

    Console.Write($"{this.GetStartingMessage()}\n\n{this.GetDescription()}\n\nHow long, in seconds, would you like for your session? ");

    int countdown = int.Parse(Console.ReadLine());

    this.SetCountDown(countdown);

    this.PauseConsole();

    int duration = 0;
    while (duration < this.GetCountDown())
    {
      Console.Write("Breathe in...3");
      Thread.Sleep(1000);
      Console.Write("\b \b");
      Console.Write("2");
      Thread.Sleep(1000);
      Console.Write("\b \b");
      Console.Write("1");
      Thread.Sleep(1000);
      Console.Write("\b \b");
      Console.Write("\n\n");


      Console.Write("Now breathe out...4");
      Thread.Sleep(1000);
      Console.Write("\b \b");
      Console.Write("3");
      Thread.Sleep(1000);
      Console.Write("\b \b");
      Console.Write("2");
      Thread.Sleep(1000);
      Console.Write("\b \b");
      Console.Write("1");
      Thread.Sleep(1000);
      Console.Write("\b \b");
      Console.Write("\n\n");


      duration += 7;
    }

    Console.Clear();
    Console.Write(this.GetEndingMessage(countdown));
    Thread.Sleep(3000);
  }
}