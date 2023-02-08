public class Entry
{

  string _userAnswer = "";

  Journal journal = new Journal();

  public string HandleEntry()
  {
    Console.WriteLine("Please select one of the following choices:");
    Console.WriteLine("1. White");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");


    _userAnswer = Console.ReadLine();


    if (_userAnswer == "1")
    {
      journal.HandleEntryOnJournal();
      return "1";
    }
    else if (_userAnswer == "2")
    {
      journal.DisplayJournal();
      return "2";

    }
    else if (_userAnswer == "3")
    {
      // journal.LoadJournal();
      return "3";
    }
    else if (_userAnswer == "4")
    {
      journal.SaveJournal();
      return "4";
    }

    return _userAnswer;



  }
}

