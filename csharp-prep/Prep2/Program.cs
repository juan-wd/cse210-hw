using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Please enter your grade: ");
        string grade = Console.ReadLine();
        string letter = Console.ReadLine();

        int Grade = int.Parse(grade);

        if (Grade >= 90)
        {
            //Console.WriteLine("Your grade is A");
            
        }
        else if (Grade >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (Grade >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (Grade >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }

        if (Grade >= 70)
        {
            Console.WriteLine("Congratulations you passed this class!");
        }
        else
        {
            Console.Write("You could not pass the Class, you will do it next time!");
        }

    }
}