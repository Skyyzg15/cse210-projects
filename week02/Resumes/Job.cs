using System;

public class Job
{
    public string _jobTitle;
    public string _Company;
    public string _startYear;
    public string _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} {_Company} {_startYear}-{_endYear}");
    }
}