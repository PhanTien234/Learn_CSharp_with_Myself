namespace Learn_CSharp.SwitchCaseStatement;

public static void Main(String[] args)
{
    // Use the day of week to print out screen the day of week
    int day = int.Parse(Console.ReadLine());
    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("Cannot find the day with that number! ");
            break;
    }
}