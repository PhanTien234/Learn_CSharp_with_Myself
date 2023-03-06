namespace Learn_CSharp.DateTimes;

public class TimeSpans

{
    static void Main(string[] args)
    {
        DateTime dt = new DateTime(2015, 12, 31);
        TimeSpan ts = new TimeSpan(25, 20, 55);
        DateTime newDate = dt.Add(ts);
        Console.WriteLine(newDate);
    }
}