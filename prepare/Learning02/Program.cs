class Program
{
  static void Main(string[] args)
  {
    Job firstJob = new Job();
    firstJob._jobTitle = "Front-End Developer";
    firstJob._companyName = "Nestec";
    firstJob._startYear = 2020;
    firstJob._endYear = 2022;


    Job secondJob = new Job();
    secondJob._jobTitle = "FullStack Developer";
    secondJob._companyName = "FYDU";
    secondJob._startYear = 2022;
    secondJob._endYear = 2023;

    Resume resume = new Resume();
    resume._name = "Nilber Mota";

    resume._jobs.Add(firstJob);
    resume._jobs.Add(secondJob);

    resume.DisplayResume();

  }
}

