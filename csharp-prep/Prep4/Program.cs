class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");

        List<int> arrNumber = new List<int>();

        string userNumber = Console.ReadLine();

        int userNumberInt = Int32.Parse(userNumber);

        while (userNumberInt != 0)
        {
            arrNumber.Add(userNumberInt);
            
            Console.Write("Enter number: ");
            userNumber = Console.ReadLine();
            userNumberInt = Int32.Parse(userNumber);
        }

        int sum = 0;
        int largestNum = -1;

        foreach(var number in arrNumber){
            sum += number;

            if (number > largestNum){
                largestNum = number;
            }
        }

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {(float)sum / arrNumber.Count}");
        Console.WriteLine($"The largest number is {largestNum}");



        
    }
}