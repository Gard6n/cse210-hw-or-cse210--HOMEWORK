namespace Foundation3;

public class Bicycles : Activity
{
    private double _distance;

    public Bicycles(double _distance,double _time) : base(_distance, _time)
    {
        this._distance = _distance;
    }
    
    public override string GetSummary()
    {
        return $"{Date()} Cycling({TimeGet()} min)- Distance: {_distance} miles, Speed: {Speed()} mph, Pace: {Pace()} min per mile";
    }
    
}