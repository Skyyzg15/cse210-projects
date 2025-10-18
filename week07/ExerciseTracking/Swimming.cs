using System;
public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthKm = 0.05;
    public Swimming(string date, int duration, int laps)
      : base(date, duration)
      {
        _laps = laps;
      }
    public override double GetDistance()
    {
        return _laps * LapLengthKm;
    }
    public override double GetSpeed()
    {
        double hours = GetDuration() / 60.0;
        return GetDistance() / hours;
    }
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}