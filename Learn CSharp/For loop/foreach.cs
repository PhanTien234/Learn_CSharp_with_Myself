namespace Learn_CSharp.For_loop;

public static void Main(String[] args)
{
    string[] cars = { "Honda", "BWM", "Ford", "Mazda" };
    foreach (var car in cars)
    {
        Console.WriteLine(car);
    }
}