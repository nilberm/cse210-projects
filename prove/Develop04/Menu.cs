public class Menu
{
  private string _menuOptions = "Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu: ";
  private string _userEntry;

  private List<int> _logActivities;

  BreathingActivity breathingActivity = new BreathingActivity();
  ReflectionActivity reflectionActivity = new ReflectionActivity();

  ListingActivity listingActivity = new ListingActivity();

  public Menu()
  {
    _logActivities = new List<int> { 0, 0, 0 };
  }
  public void RunProgram()
  {
    _userEntry = "0";

    while (_userEntry != "4")
    {
      if (_userEntry == "1")
      {
        breathingActivity.Run();
        _logActivities[0] = _logActivities[0] + 1;
      }
      else if (_userEntry == "2")
      {
        reflectionActivity.Run();
        _logActivities[1] = _logActivities[1] + 1;
      }
      else if (_userEntry == "3")
      {
        listingActivity.Run();
        _logActivities[2] = _logActivities[2] + 1;
      }

      Console.Clear();
      Console.Write(_menuOptions);
      _userEntry = Console.ReadLine();
    }

    Console.Write($"\nYou have done the\nBreathing Activity {_logActivities[0]} times\nReflection Activity {_logActivities[1]} times\nListing Activity {_logActivities[2]} times");
    Thread.Sleep(5000);
  }
}