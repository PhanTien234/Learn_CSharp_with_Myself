namespace Learn_CSharp.Array;

public class CountElementByForeach
{
    static void Main(string[] args)
    {
        string[] cars = { "Honda", "BWM", "Ford", "Mazda" };
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}