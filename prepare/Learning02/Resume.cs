using System;

//Create the Resume class.
public class Resume
{
    //Create the member variable for the person's name.
    public string _personName;

    //Create the member variable for the list of Jobs.
    public List<Job> _listOfJobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"name: {_personName}");
        Console.WriteLine("Jobs:");
    }

}
