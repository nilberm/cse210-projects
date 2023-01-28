class Load
{
  private List<string> userRepository = new List<string>();

  public void LoadFile(string fileName)
  {
    string newFileName = $"journal/{fileName}";

    try
    {
      string[] lines = File.ReadAllLines(newFileName);
      userRepository.InsertRange(0, lines);
    }
    catch (IOException e)
    {
      Console.WriteLine("An error occurred while reading the file:");
      Console.WriteLine(e.Message);
    }
  }
  public List<string> GetUserRepository()
  {
    return userRepository;
  }
}