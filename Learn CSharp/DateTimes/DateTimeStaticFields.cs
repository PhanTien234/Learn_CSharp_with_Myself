namespace Learn_CSharp.DateTimes;

public class DateTimeStaticFields
{
    static void Main(string[] args)
    {
        DateTime currentDateTime = DateTime.Now;
        DateTime todaysDate = DateTime.Today;
        DateTime currentDateTimeUTC = DateTime.UtcNow;

        DateTime maxDateTimeValue = DateTime.MaxValue;
        DateTime minDateTimeValue = DateTime.MinValue;
        Console.WriteLine($"Current DateTime {currentDateTime}");
        Console.WriteLine($"Today's DateTime {todaysDate}");
        Console.WriteLine($"Current DateTime UTC Timezone {currentDateTimeUTC}");
        Console.WriteLine($"Max DateTime Value {maxDateTimeValue}");
        Console.WriteLine($"Min DateTime Value {minDateTimeValue}");
    }
}