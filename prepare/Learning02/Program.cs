using System;

class Program
{
    static void Main(string[] args)
    {
    //Create a new job instance named job1   
        Job job1 = new Job();

    //Set the member variables using the dot notation
        job1._company = "Apex Inteliserve";
        job1._jobTitle = "Sales Executive";
        job1._startYear = 2021;
        job1._endYear = 2022;
        job1.DisplayJobDetails();

    //Create a new job instance named job1  
        Job job2 = new Job();

    //Set the member variables using the dot notation
        job2._company = "Mangi Sales Co";
        job2._jobTitle = "Purchasing mamanger";
        job2._startYear = 2018;
        job2._endYear = 2020;
        job2.DisplayJobDetails();

    //Verify that you can display the company of this job on the screen, 
    //again using the dot notation to access the member variable.
    //    Console.WriteLine(job1._company);
    //    Console.WriteLine(job1._company);

        Resume resume  = new Resume();
        resume._listOfJobs.Add(job1);
        resume._listOfJobs.Add(job2);
        Console.WriteLine(resume._listOfJobs[0]._jobTitle);
        





    }
}