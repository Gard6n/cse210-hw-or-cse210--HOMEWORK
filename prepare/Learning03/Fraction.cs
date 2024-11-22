namespace Learning03;

public class Fraction
{
    private int _top;
    private int _bottom;

    public void Fraction1()
    {
        _top = 1;
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}\n");
    }

    public void Fraction2()
    {
        Console.WriteLine($"{_top}\n");
    }

    public void Fraction3()
    {
        Console.WriteLine($"{_top}/{_bottom}\n");
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    
}