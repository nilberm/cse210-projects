public class Job
{
  public string _companyName = "";
  public string _jobTitle = "";
  public int _startYear = 0;
  public int _endYear = 0;


  public void DisplayJobInformation()
  {
    Console.WriteLine($"{_jobTitle} ({_companyName}) {_companyName}-{_endYear}");
  }

}