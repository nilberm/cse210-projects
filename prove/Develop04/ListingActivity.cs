public class ListingActivity : Activity
{
  private List<string> _randomPrompt;
  private List<string> _userList;

  Random rand = new Random();

  public ListingActivity() : base(startMsg: "Listing Activity", description: "This activity will assist you in reflecting on the positive aspects of your life by prompting you to jot down as many things as possible within a specific category.")
  {
    _randomPrompt = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    _userList = new List<string>();
  }

  public void Run()
  {
    Console.Clear();

    Console.Write($"{this.GetStartingMessage()}\n\n{this.GetDescription()}\n\nHow long, in seconds, would you like for your session? ");

    int countdown = int.Parse(Console.ReadLine());

    this.SetCountDown(countdown);

    this.PauseConsole();

    Console.Write("\nList as many responses you can to the following prompt:\n");
    Console.Write($"--- {_randomPrompt[rand.Next(0, _randomPrompt.Count)]} ---\n");

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
    Console.Write("\b \b \n");


    int duration = 0;
    while (duration < this.GetCountDown())
    {
      Console.Write("> ");
      string _userEntry = Console.ReadLine();
      _userList.Add(_userEntry);

      duration += 2;
    }

    Console.Write($"You listed {_userList.Count} items!\n");

    Console.Write(this.GetEndingMessage(countdown));
    Thread.Sleep(3000);





  }


}