class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the Journal Program!");

    string userAnswer = "";
    string userWriting = "";

    List<string> userRepository = new List<string>();

    RandomProps randomProps = new RandomProps();

    Load load = new Load();

    Save save = new Save();

    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();


    while (userAnswer != "5")
    {
      Console.WriteLine("Please select one of the following choices:");
      Console.WriteLine("1. White");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4. Save");
      Console.WriteLine("5. Quit");


      userAnswer = Console.ReadLine();


      if (userAnswer == "1")
      {
        string randomQuestion = randomProps.DisplayProps();

        Console.WriteLine(randomQuestion);

        userWriting = Console.ReadLine();

        userRepository.Add($"Data: {dateText} - {randomQuestion} \n{userWriting}");
      }
      else if (userAnswer == "2")
      {
        foreach (string line in userRepository)
        {
          Console.WriteLine(line);

        }
      }
      else if (userAnswer == "3")
      {
        Console.Write("Enter the name of the file: ");

        string fileName = Console.ReadLine();

        load.LoadFile(fileName);
        userRepository.InsertRange(0, load.GetUserRepository());
      }
      else if (userAnswer == "4")
      {
        Console.Write("Enter the name of the file: ");

        string fileName = Console.ReadLine();

        save.SaveFile(userRepository, fileName);
      }

    }
  }

}