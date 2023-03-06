namespace Learn_CSharp.DateTimes;

public class Tickss
{
    static void Main(string[] args)
    {
        DateTime dt = new DateTime(63637000000000000);
        Console.WriteLine(dt);
        Console.WriteLine(DateTime.MinValue.Ticks); //min value of ticks
        Console.WriteLine(DateTime.MaxValue.Ticks); //max value of ticks
    }
}