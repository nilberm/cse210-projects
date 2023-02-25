public class ReflectionActivity : Activity
{
  private List<string> _randomPrompt;
  private List<string> _randomQuestions;
  Random rand = new Random();

  public ReflectionActivity() : base(startMsg: "Reflection Activity", description: "This exercise will assist you in reflecting on instances in your life where you have demonstrated strength and resilience. This will enable you to acknowledge the power you possess and how you can utilize it in other areas of your life.")
  {
    _randomPrompt = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };

    _randomQuestions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
  }

  public void Run()
  {

    Console.Clear();

    Console.Write($"{this.GetStartingMessage()}\n\n{this.GetDescription()}\n\nHow long, in seconds, would you like for your session? ");

    int countdown = int.Parse(Console.ReadLine());

    this.SetCountDown(countdown);

    this.PauseConsole();

    Console.WriteLine("Consider the following prompt:\n");
    Console.WriteLine($"--- {_randomPrompt[rand.Next(0, _randomPrompt.Count)]} ---\n");
    Console.WriteLine("When you have something in mind, press ENTER to continue.");
    Console.Read();
    Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
    Console.Write("You may begin in: 5");
    Thread.Sleep(1000);
    Console.Write("\b \b");
    Console.Write("4");
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

    Console.Clear();
    int duration = 0;
    while (duration < this.GetCountDown())
    {
      Console.Write($"> {_randomQuestions[rand.Next(0, _randomQuestions.Count)]} ");
      this.BarAnimation();
      Console.Write("\n\n");
      duration += 8;
    }

    Console.Clear();
    Console.Write(this.GetEndingMessage(countdown));
    Thread.Sleep(3000);

  }
}