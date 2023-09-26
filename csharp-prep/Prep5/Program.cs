using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        WelcomeMessage();

        string userName = UserName();

        int userNumber = UserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program");          
    }
    static string UserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int UserNumber()
    {
        Console.WriteLine("Please indicate your favorite number");
        string number = Console.ReadLine();
        int Number = int.Parse(number);
        
        return Number;
    }

    static int SquareNumber(int Number)
    {
        int Square = Number * Number;
        return Square;
    }

    static void DisplayResult(string name, int Square)
    {
    Console.WriteLine($"{name}, the square root of your number is {Square}.");
    }
}