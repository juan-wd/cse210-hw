using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Please enter your grade: ");
        //string grade = Console.ReadLine();
        string letter = Console.ReadLine();

        //int Grade = int.Parse(grade);
        int Letter = int.Parse(letter);

        string grade = "";

        // if (grade >= 90)
        if (Letter >= 90)
        {
            //Console.WriteLine("Your grade is A");
            grade = "A";
        }
        //else if (Grade >= 80)
        else if (Letter >= 80)
        {
            //Console.WriteLine("Your grade is B");
            grade = "B";
        }
        //else if (Grade >= 70)
        else if (Letter >= 70)
        {
            //Console.WriteLine("Your grade is C");
            grade = "C";
        }
        //else if (Grade >= 60)
        else if (Letter >= 60)
        {
            //Console.WriteLine("Your grade is D");
            grade = "D";
        }
        else
        {
            grade = "F";
        }

            Console.WriteLine($"Your grade is {Letter}.");

        if (Letter >= 70)
        {
            Console.WriteLine("Congratulations you passed this class!");
        }
        else
        {
            Console.Write("You could not pass the Class, you will do it next time!");
        }

    }
}