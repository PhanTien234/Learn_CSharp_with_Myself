namespace Learn_CSharp.DateTimes;

public class ConvertStringToDateTime
{
    static void Main(string[] args)
    {
        var str = "5/12/2020";
        DateTime dt;
        var isValidDate = DateTime.TryParse(str, out dt);
        if(isValidDate)
            Console.WriteLine(dt);
        else
        {
            Console.WriteLine($"{str} is not a valid date string");
        }
    }
}

// The result: 5/12/2020 12:00:00 AM