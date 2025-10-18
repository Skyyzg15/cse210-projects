using System;
public abstract class Activity
{
    private DateTime _date;
    private int _duration;
    public Activity(string date, int duration)
    {
        _date = DateTime.Parse(date);
        _duration = duration;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date: dd MMM yyyy} {this.GetType().Name} ({_duration} min): " +
               $"Distance {GetDistance():F2} km," +
               $"Speed {GetSpeed():F2} kph," +
               $"Pace {GetPace():F2} min per km";
    }
}