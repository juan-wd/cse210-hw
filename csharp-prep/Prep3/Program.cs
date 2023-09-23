using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!\n");

        //For excersise 1 and 2
        //Console.WriteLine("What is your magic number? ");
        //string Number = Console.ReadLine();
        //int magicNumber = int.Parse(Number);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int guessNumber = -1;

        while (guessNumber != number)
        {
        
            Console.WriteLine("Make your guess! ");
            string Guess = Console.ReadLine();
            guessNumber = int.Parse(Guess); 

        if (number > guessNumber)
        {
            Console.WriteLine("Guess Higher number! ");    
        }
        else if (number < guessNumber)
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