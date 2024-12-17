namespace Foundation3;

public class Swimming : Activity
{
    private double _distance;

    public Swimming(double distance, double time) : base(distance, time)
    {
        this._distance = distance;

    }

    private string PoolLaps()
    {
        double laps = _distance / 50;
        return laps.ToString();
    }

    public override string GetSummary()
    {
        return
            $"{Date()} Cycling({TimeGet()} min)- Distance: {_distance} meters, Speed: {Speed()} mph, Pace: {Pace_In_Meters()} sec per meters, Laps: {PoolLaps()}";
    }
}