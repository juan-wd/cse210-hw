using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();   
    
        Console.Write("What is your second name? ");
        string secondname = Console.ReadLine();

        Console.WriteLine($"\nYour name is {secondname}, {firstname} {secondname}.");


    }
        
}