using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationMinutes / GetDistance();
    }
}
