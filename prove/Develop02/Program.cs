class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the Journal Program!");

    Entry entry = new Entry();

    while (entry.HandleEntry() != "5")
    {
      entry.HandleEntry();
    }


  }

}