public class Save
{

  public void SaveFile(List<string> userRepository, string fileName)
  {
    string _newFileName = $"journal/{fileName}";

    using (StreamWriter outputFile = new StreamWriter(_newFileName))
    {
      foreach (string line in userRepository)
      {
        outputFile.WriteLine(line);
      }
    }
  }

}