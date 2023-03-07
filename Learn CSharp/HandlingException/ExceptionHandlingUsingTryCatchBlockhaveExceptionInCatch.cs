namespace Learn_CSharp.HandlingException;

public class ExceptionHandlingUsingTryCatchBlockhaveExceptionInCatch
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number: ");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Square of {num} is {num * num}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error info:" + ex.Message);
        }
        finally
        {
            Console.Write("Re-try with a different number.");
        }
    }
}