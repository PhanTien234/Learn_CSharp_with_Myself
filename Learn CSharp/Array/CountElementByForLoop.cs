namespace Learn_CSharp.Array;

public class CountElementByForLoop
{
    static void Main(string[] args)
    {
        string[] cars = { "Yamaha", "Tesla", "BMW", "Toyata" };
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
    }
}