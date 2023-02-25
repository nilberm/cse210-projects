public class Activity
{
  private string _startingMessage;
  private string _activityName;
  private string _description;

  private int _countdown;

  public Activity(string startMsg, string description)
  {
    _startingMessage = $"Welcome to the {startMsg}";
    _activityName = startMsg;
    _description = description;
  }

  public string GetStartingMessage()
  {
    return _startingMessage;
  }

  public string GetEndingMessage(int countdown)
  {
    return $"Well done!! \n\nYou have completed another {countdown} seconds of the {_activityName}.";
  }

  public string GetDescription()
  {
    return _description;
  }

  public void SetCountDown(int number)
  {
    _countdown = number;
  }

  public int GetCountDown()
  {
    return _countdown;
  }

  public void PauseConsole()
  {
    Console.Clear();
    Console.WriteLine("Get ready...");
    this.BarAnimation();

    Console.Clear();
    Console.WriteLine("Get ready...\n\n");
  }

  public void BarAnimation()
  {
    for (int i = 0; i < 8; i++)
    {
      Console.Write("|");
      Thread.Sleep(240);
      Console.Write("\b \b");
      Console.Write("/");
      Thread.Sleep(240);
      Console.Write("\b \b");
      Console.Write("-");
      Thread.Sleep(240);
      Console.Write("\b \b");
      Console.Write("\\");
      Thread.Sleep(240);
      Console.Write("\b \b");
    }
  }

}