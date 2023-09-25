using System;
using System.Linq;
using System.Collections.Generic;
//Console.WriteLine("Hello Prep4 World!");

List<int> numbers = new List<int>();

// First part, create a while loop condition to add items to the list.
int userNumber = -1;

while (userNumber != 0) 
{
    Console.WriteLine("Indicate your list of numbers, type 0 when you have finished");
    string numbersList = Console.ReadLine();
    userNumber = int.Parse(numbersList);

    if (userNumber != 0)
    {
        numbers.Add(userNumber);
        Console.WriteLine("Please select another number");
    }

    else if (userNumber == 0)
    {
        Console.WriteLine("Thank you!");

    }

}

// Part 2, use foreach to perform sum caluclation

int sumNumbers = 0;
foreach (int number in numbers)
{
    sumNumbers += number;
}

Console.WriteLine($"The sum of your numbers is: {sumNumbers}.");

// Part 3, count items in the list to perform average calculation of the total of items

float averageDecimal = (float)sumNumbers / numbers.Count;
Console.WriteLine($"The average of numbers is {averageDecimal}");

// Part 4, I found on https://www.techiedelight.com/ the usage of "System.Linq" to perform Max value method.

Console.WriteLine("The maximum number is: "+ numbers.Max());

