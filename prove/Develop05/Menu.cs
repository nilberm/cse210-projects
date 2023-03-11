public class Menu
{

  private string _userEntry;
  private string _totalPoints = "0";

  private List<List<string>> _listOfGoals = new List<List<string>> { };

  Goals goals = new Goals();

  FileGoals fileGoals = new FileGoals();
  public void Run()
  {
    _userEntry = "0";


    while (_userEntry != "6")
    {

      Console.WriteLine($"You have {_totalPoints}.");

      Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
      Console.Write("Select a choice from the menu: ");
      _userEntry = Console.ReadLine();

      if (_userEntry == "1")
      {
        // Create Goal
        List<string> tempGoal = goals.CreateGoals();

        _listOfGoals.Add(tempGoal);
      }
      else if (_userEntry == "2")
      {
        // List Goals
        int tempCount = 1;
        Console.WriteLine("The goals are: ");

        foreach (List<string> listOfGoal in _listOfGoals)
        {

          if (listOfGoal.Count == 5)
          {
            string tempType = listOfGoal[0];
            string tempName = listOfGoal[1];
            string tempDescription = listOfGoal[2];
            string tempIsCompleted = bool.Parse(listOfGoal[4]) ? "X" : " ";

            Console.WriteLine($"{tempCount}. [{tempIsCompleted}] {tempName} ({tempDescription})");

            tempCount += 1;
          }

          else if (listOfGoal.Count == 4)
          {
            string tempType = listOfGoal[0];
            string tempName = listOfGoal[1];
            string tempDescription = listOfGoal[2];

            Console.WriteLine($"{tempCount}. [ ] {tempName} ({tempDescription})");

            tempCount += 1;
          }
          else if (listOfGoal.Count == 8)
          {
            string tempType = listOfGoal[0];
            string tempName = listOfGoal[1];
            string tempDescription = listOfGoal[2];

            string tempCurrentTimesToExtra = listOfGoal[4];
            string tempTimesToExtra = listOfGoal[5];

            string tempIsCompleted = bool.Parse(listOfGoal[7]) ? "X" : " ";

            Console.WriteLine($"{tempCount}. [{tempIsCompleted}] {tempName} ({tempDescription}) -- Currently completed {tempCurrentTimesToExtra}/{tempTimesToExtra}");

            tempCount += 1;
          }
        }
      }
      else if (_userEntry == "3")
      {
        // Save Goals
        Console.WriteLine("Enter the file name: ");
        string fileName = Console.ReadLine();

        fileGoals.Save(_listOfGoals, _totalPoints, fileName);
      }
      else if (_userEntry == "4")
      {
        // Load Goals
        Console.WriteLine("Enter the file name: ");
        string fileName = Console.ReadLine();

        fileGoals.Load(fileName);

        _listOfGoals = fileGoals.GetUserGoals();
        _totalPoints = fileGoals.GetTotalPoints();

      }
      else if (_userEntry == "5")
      {
        // Record Event
      }

    }


  }
}