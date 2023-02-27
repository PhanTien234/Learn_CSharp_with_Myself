namespace Learn_CSharp.Enum;

public class ExEnum
{
    enum Level
    {
        Low,
        Medium,
        High
    }
    static void Main(string[] args)
    {
        Level myVar = Level.Medium;
        Console.WriteLine(myVar);
    }
}