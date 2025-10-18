using System;
public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int duration, double speed)
       : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        double hours = GetDuration() / 60.0;
        return _speed * hours;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}