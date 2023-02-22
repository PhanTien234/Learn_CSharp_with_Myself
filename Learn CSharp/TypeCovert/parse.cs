namespace Learn_CSharp.TypeCovert;

public class parse
{
    public static void Main(string[] args)
    {
        string value = "69";
        int number = int.Parse(value);
        Console.WriteLine("Kieu du lieu ban dau: " + value.GetType());
        Console.WriteLine("Kieu du lieu ban dau: " + number.GetType());
    }
}