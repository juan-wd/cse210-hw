using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.WriteLine("What is your magic number? ");
        string Number = Console.ReadLine();
        int magicNumber = int.Parse(Number);

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
        
        //Console.WriteLine("Make your guess! ");
        //string Guess = Console.ReadLine();
        //int guessNumber = int.Parse(Guess);    

        if (magicNumber > guessNumber)
        {
            Console.WriteLine("Guess Higher number! ");    
        }
        else if (magicNumber < guessNumber)
        {
            Console.WriteLine("Guess lower! ");
        }
        else
        {
            Console.WriteLine("You guessed it! ");
        }
    
        }

    }
}