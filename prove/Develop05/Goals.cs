public class Goals : BaseGoal
{

  private string _userEntry;

  private List<string> _goalTemp;

  public List<string> CreateGoals()
  {
    Console.Clear();
    Console.WriteLine("The type of Goals are:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.Write("Which type of goal would like to create? ");


    _userEntry = Console.ReadLine();

    List<string> tempGoal = CreateGoal(_userEntry);

    return tempGoal;

  }

  public override List<string> CreateGoal(string typeGoal)
  {
    if (typeGoal == "1")
    {
      _typeGoal = "Simple Goal";

      Console.WriteLine("What is the name of your goal? ");
      _nameGoal = Console.ReadLine();

      Console.WriteLine("What is a short description of it? ");
      _description = Console.ReadLine();

      Console.WriteLine("What is the amount of points associated with this goal? ");
      _amountPoints = Console.ReadLine();

      _isCompleted = false;

      _goalTemp = new List<string> { _typeGoal, _nameGoal, _description, _amountPoints, _isCompleted.ToString() };

      return _goalTemp;
    }
    else if (typeGoal == "2")
    {
      _typeGoal = "Eternal Goal";

      Console.WriteLine("What is the name of your goal? ");
      _nameGoal = Console.ReadLine();

      Console.WriteLine("What is a short description of it? ");
      _description = Console.ReadLine();

      Console.WriteLine("What is the amount of points associated with this goal? ");
      _amountPoints = Console.ReadLine();

      _goalTemp = new List<string> { _typeGoal, _nameGoal, _description, _amountPoints };

      return _goalTemp;
    }
    else if (typeGoal == "3")
    {
      _typeGoal = "Checklist Goal";

      Console.WriteLine("What is the name of your goal? ");
      _nameGoal = Console.ReadLine();

      Console.WriteLine("What is a short description of it? ");
      _description = Console.ReadLine();

      Console.WriteLine("What is the amount of points associated with this goal? ");
      _amountPoints = Console.ReadLine();

      Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
      _timesToExtra = Console.ReadLine();

      Console.WriteLine("What is the bonus for accomplishing it that many times? ");
      _extraPoints = Console.ReadLine();

      _isCompleted = false;

      _currentTimesToExtra = "0";

      _goalTemp = new List<string> { _typeGoal, _nameGoal, _description, _amountPoints, _currentTimesToExtra, _timesToExtra, _extraPoints, _isCompleted.ToString() };

      return _goalTemp;
    }
    else
    {
      return _goalTemp;
    }
  }

}