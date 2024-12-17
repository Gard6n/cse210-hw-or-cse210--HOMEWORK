namespace Foundation3;

public abstract class Activity
{
   private double _speed;
   private double _distance;
   private double _time;
   public Activity(double distance, double time)
   {
      _distance = distance;
      _time = time;
   }

   public abstract string GetSummary();

   public string Date()
   {
      DateTime start = DateTime.Now;
      string time = start.Date.ToShortDateString();
      return time;
   }
   
   public string Speed()
   {
      double _speed = _distance / _time;
      return _speed.ToString();
   }

   public string Pace()
   {
      double _pace = _time / _distance;
      return _pace.ToString();
   }
   
   public double TimeGet()
   {
      return _time;
   }
}                