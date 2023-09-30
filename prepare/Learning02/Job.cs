using System;

 //Create the class public class Job.
 public class Job
{
//Create member variables in the class for each element that this class should contain. 
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {
    }
    //add a method (member function) to display the job details.
    //Should not have any parameters and does not need to return anything.
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} ");
    }

}