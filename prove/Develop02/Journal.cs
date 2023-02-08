public class Journal
{
  string _userWriting = "";

  Load load = new Load();

  Save save = new Save();

  RandomProps randomProps = new RandomProps();

  List<string> userRepository = new List<string>();

  private string GetTimeString()
  {
    DateTime theCurrentTime = DateTime.Now;
    string _dateText = theCurrentTime.ToShortDateString();

    return _dateText;
  }

  public void HandleEntryOnJournal()
  {
    string randomQuestion = randomProps.DisplayProps();

    Console.WriteLine(randomQuestion);

    _userWriting = Console.ReadLine();

    userRepository.Add($"Data: {this.GetTimeString()} - {randomQuestion} \n{_userWriting}");
  }

  public void DisplayJournal()
  {
    foreach (string line in userRepository)
    {
      Console.WriteLine(line);

    }
  }

  public void SaveJournal()
  {
    Console.Write("Enter the name of the file: ");

    string fileName = Console.ReadLine();

    save.SaveFile(userRepository, fileName);
  }

  public void LoadJournal()
  {
    Console.Write("Enter the name of the file: ");

    string fileName = Console.ReadLine();

    load.LoadFile(fileName);
    userRepository.InsertRange(0, load.GetUserRepository());
  }
}