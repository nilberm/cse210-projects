public class FileGoals
{

  private List<string> _userGoals = new List<string>();
  private string totalPoints;
  public void Save(List<List<string>> userGoals, string totalPoints, string fileName)
  {
    string _newFileName = $"files/{fileName}";

    using (StreamWriter outputFile = new StreamWriter(_newFileName))
    {
      outputFile.WriteLine(totalPoints);

      foreach (List<string> line in userGoals)
      {
        outputFile.WriteLine(String.Join(",", line));

      }
    }
  }

  public void Load(string fileName)
  {
    string _newFileName = $"files/{fileName}";

    try
    {
      string[] lines = File.ReadAllLines(_newFileName);
      totalPoints = lines[0];

      _userGoals.InsertRange(0, lines.Skip(1).ToArray());

    }
    catch (IOException e)
    {
      Console.WriteLine("An error occurred while reading the file:");
      Console.WriteLine(e.Message);
    }
  }

  public List<List<string>> GetUserGoals()
  {
    List<List<string>> tempGoals = new List<List<string>>() { };

    foreach (string userGoal in _userGoals)
    {
      tempGoals.Add(userGoal.Split(",").ToList());
    }

    return tempGoals;
  }

  public string GetTotalPoints()
  {
    return totalPoints;
  }


}