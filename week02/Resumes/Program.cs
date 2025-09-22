using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job("Bloom", "Data Entry Specialist", 2023, 2024);
        Job job2 = new Job("KADEA SOFTWARE", "Assistant Coach", 2024, 2025);
        List<Job> jobList = new List<Job>();
        jobList.Add(job1);
        jobList.Add(job2);

        //Without using the constructor
        //Resume resume1 = new Resume ();
        //resume1._name = "Jose Okitandende Okungu";
        //resume1.jobs.Add(job1);
        //resume1.jobs.Add(job2);
        //resume1.DisplayResume();

        //Using the constructor
        Resume resume = new Resume("Jose Okitandende Okungu", jobList);
        resume.DisplayResume();


        Console.ReadLine();
    }
}

public class Job
{
    public string _company = " ";
    public string _jobTitle = " ";
    public int _startYear = 0;
    public int _endYear = 0;

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        this._company = company;
        this._jobTitle = jobTitle;
        this._startYear = startYear;
        this._endYear = endYear;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }

}


public class Resume 
{
    //This class has the attribute _name and a list of Jobs and the method
    //That displays the resume with both the name and jobs.

    public string _name;
    public List<Job> jobs = new List<Job>();

    public Resume(string name, List<Job> jobsList)
    {
        this._name = name;
        this.jobs = jobsList;
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in jobs)
        {
            Console.WriteLine($"{job._jobTitle} ({job._company}) {job._startYear} - {job._endYear}");
        }



    }
}