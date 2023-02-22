namespace Learn_CSharp.TypeCovert;

public class TryParse
{
    public static void Main(string[] args)
    {
        int resultValue;
        bool isSuccess;
        string value1 = "69";
        string value2 = "GCD";
        // Truong hop 1: Chuyen value1 sang int
        isSuccess = int.TryParse(value1, out resultValue);
        Console.WriteLine($"Truong hop 1: {isSuccess}, gia tri la: {resultValue}");
        // Truong hop 2: chuyen value2 sang int
        isSuccess = int.TryParse(value2, out resultValue);
        Console.WriteLine($"Truong hop 2: {isSuccess}; gia tri la: {resultValue}");
    }
}