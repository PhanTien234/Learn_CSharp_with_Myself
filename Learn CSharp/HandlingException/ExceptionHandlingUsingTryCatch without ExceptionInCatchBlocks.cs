namespace Learn_CSharp.HandlingException;

public class ExceptionHandlingUsingTryCatch_without_ExceptionInCatchBlocks
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number: ");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Square of {num} is {num * num}");
        }
        catch
        {
            Console.Write("Error occurred");
        }
        finally
        {
            Console.Write("Re-try with a different number");
        }
    }
}