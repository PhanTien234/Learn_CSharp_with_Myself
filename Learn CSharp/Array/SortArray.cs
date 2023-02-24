namespace Learn_CSharp.Array;

public class SortArray
{
    static void Main(string[] args)
    {
        string[] cars = { "Honda", "Toyata", "BMW", "Ford" };
        System.Array.Sort(cars);
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
    }
}