class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the Journal Program!");

    string userAnswer = "";
    string userWriting = "";

    List<string> userRepository = new List<string>();

    RandomProps randomProps = new RandomProps();

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
        Console.WriteLine(userRepository);
      }

    }
  }

}