namespace Learning05;

class Program
{
    static void Main(string[] args)
    {
        Assignment sign = new Assignment("Rick", "Math topic");
        Console.WriteLine(sign.GetSummery());

        MathAssignment ma = new MathAssignment("David", "really hard math", "2.4", "1-20000");
        Console.WriteLine(ma.GetSummery());
        Console.WriteLine(ma.GetHomeworklist());

        WritingAssignment wa = new WritingAssignment("That Dude", "Apples", "Why are apples green?");
        Console.WriteLine(wa.GetSummery());
        Console.WriteLine(wa.GetWritingInfomation());
    }
}