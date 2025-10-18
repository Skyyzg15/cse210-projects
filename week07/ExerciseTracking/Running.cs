using System;
public class Running : Activity
{
    private double _distance;
    public Running(string date, int duration, double distance)
       : base(date, duration)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double hours = GetDuration() / 60.0;
        return _distance / hours;
    }
    public override double GetPace()
    {
        return GetDuration() / _distance;
    }
}