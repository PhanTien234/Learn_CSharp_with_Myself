namespace Learn_CSharp.DateTimes;

public class SubstractDates
{
    static void Main(string[] args)
    {
        DateTime dt1 = new DateTime(2015, 12, 31);
        DateTime dt2 = new DateTime(2016, 2, 2);
        TimeSpan result = dt2.Subtract(dt1);
        Console.WriteLine(result);
    }
}