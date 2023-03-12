public class RecordEvents
{

  private List<List<string>> _tempGoals;
  private int _tempTotalPoints;
  public void RecordEventGoal(string currentTotalPoints, string indexGoal, List<List<string>> listOfGoals)
  {
    _tempGoals = listOfGoals;
    _tempTotalPoints = int.Parse(currentTotalPoints);

    int tempIndex = int.Parse(indexGoal);

    if (_tempGoals[tempIndex][0] == "Simple Goal")
    {
      _tempGoals[tempIndex][4] = "True";
      _tempTotalPoints += int.Parse(_tempGoals[tempIndex][3]);

      Console.WriteLine($"Congratulations! You have earned {_tempGoals[tempIndex][3]} points!");
      Console.WriteLine($"You now have {_tempTotalPoints}");

    }
    else if (_tempGoals[tempIndex][0] == "Eternal Goal")
    {
      _tempTotalPoints += int.Parse(_tempGoals[tempIndex][3]);

      Console.WriteLine($"Congratulations! You have earned {_tempGoals[tempIndex][3]} points!");
      Console.WriteLine($"You now have {_tempTotalPoints}");
    }
    else if (_tempGoals[tempIndex][0] == "Checklist Goal")
    {
      _tempTotalPoints += int.Parse(_tempGoals[tempIndex][3]);

      if (int.Parse(_tempGoals[tempIndex][4]) < int.Parse(_tempGoals[tempIndex][5]))
      {
        _tempGoals[tempIndex][4] = (int.Parse(_tempGoals[tempIndex][4]) + 1).ToString();

        if (int.Parse(_tempGoals[tempIndex][4]) == int.Parse(_tempGoals[tempIndex][5]))
        {
          _tempTotalPoints += int.Parse(_tempGoals[tempIndex][6]);
          _tempGoals[tempIndex][7] = "True";

          Console.WriteLine($"Congratulations! You have earned {(int.Parse(_tempGoals[tempIndex][3]) + int.Parse(_tempGoals[tempIndex][6]))} points!");
          Console.WriteLine($"You now have {_tempTotalPoints}");
        }
        else
        {
          Console.WriteLine($"Congratulations! You have earned {int.Parse(_tempGoals[tempIndex][3])} points!");
          Console.WriteLine($"You now have {_tempTotalPoints}");
        }
      }
    }
  }

  public List<List<string>> GetListOfGoals()
  {
    return _tempGoals;
  }

  public string GetTotalPoints()
  {
    return _tempTotalPoints.ToString();
  }
}