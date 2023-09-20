using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.WriteLine("What is your magic number? ");
        string Number = Console.ReadLine();
        int magicNumber = int.Parse(Number);

        Console.WriteLine("Make your guess! ");
        string Guess = Console.ReadLine();
        int guessNumber = int.Parse(Guess);



    }
}