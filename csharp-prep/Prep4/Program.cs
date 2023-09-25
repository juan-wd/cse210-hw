using System;

using System.Collections.Generic;
//Console.WriteLine("Hello Prep4 World!");

List<int> numbers = new List<int>();

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

int sumNumbers = 0;
foreach (int number in numbers)
{
    sumNumbers += number;
}

Console.WriteLine($" The sum of your numbers is: {sumNumbers}.");


int averageNumbers = 0;
float numberDecimal = (float)sumNumbers;

for (int i = 0; i < numbers.Count; i++)
{
    averageNumbers = (int)(numberDecimal / i);
}
Console.WriteLine($"The average of numbers is {averageNumbers}");

