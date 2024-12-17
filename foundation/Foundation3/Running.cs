namespace Foundation3;

public class Running : Activity
{
    private double _distance;

    public Running(double distance,double time):base(distance,time)
    {
     this._distance = distance;
    }
    
    public override string GetSummary()
    {
        return $"{Date()} Running({TimeGet()} min)- Distance: {_distance} miles, Speed: {Speed()} mph, Pace: {Pace()} min per mile";
    }
}