class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int gradeInt = Int32.Parse(grade);

        if (gradeInt < 60) 
        {
        Console.Write("Your grade is: F");
        }
        else if (gradeInt >= 90 ) 
        {
        Console.Write("Your grade is: A");
        }
        else if (gradeInt >= 80 ) 
        {
        Console.Write("Your grade is: B");
        }
        else if (gradeInt >= 70 ) 
        {
        Console.Write("Your grade is: C");
        }
        else if (gradeInt >= 60 ) 
        {
        Console.Write("Your grade is: D");
        }

        if (gradeInt > 60 && gradeInt < 93) 
        {

            if ((gradeInt % 10) >= 7) 
            {
            Console.WriteLine("+");
            } else if ((gradeInt % 10) < 3) 
            {
            Console.WriteLine("-");
            }
            else 
            {
            Console.WriteLine("");
            }
        } else 
        {
            Console.WriteLine("");
        }

        if (gradeInt >= 70 ) 
        {
        Console.Write("Congratulation, You Pass!");
        } else 
        {
        Console.Write("Continue to study!");
        }

    }
}