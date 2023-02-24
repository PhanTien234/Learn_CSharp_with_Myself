namespace Learn_CSharp.Array;

public class LinqInArray
{
    static void Main(string[] args)
    {
        int[] myNumbers = { 5, 1, 8, 9 };
        //return to the highest value
        Console.WriteLine("The highest value: " + myNumbers.Max());
        //return to the lowest value
        Console.WriteLine("The lowest value: " + myNumbers.Min());
        //return to Sum of value
        Console.WriteLine("Sum of value: " + myNumbers.Sum());
    }
}