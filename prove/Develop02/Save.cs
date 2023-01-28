public class Save
{

  public void SaveFile(List<string> userRepository, string fileName)
  {
    string newFileName = $"journal/{fileName}";

    using (StreamWriter outputFile = new StreamWriter(newFileName))
    {
      foreach (string line in userRepository)
      {
        outputFile.WriteLine(line);
      }
    }
  }

}