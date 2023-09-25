using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");

        void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program");
        
        }

        void DisplayUserName(string Name)
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Your name is {userName}");
        }
    }
}