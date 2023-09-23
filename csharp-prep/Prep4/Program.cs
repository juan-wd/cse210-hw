using System;

using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        
        List<int> numbers = new List<int>();
        
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Indicate your list of numbers, type 0 when you have finished");
            string numbersList = Console.ReadLine();
            userNumber = int.Parse(numbersList);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
                Console.Write("Please select another number");
            }

            else if (userNumber == 0)
            {
                Console.Write("Thank you!");

            } 





        }
    }
}