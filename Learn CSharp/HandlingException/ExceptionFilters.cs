namespace Learn_CSharp.HandlingException;

public class ExceptionFilters
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number to divide 100: ");
        try
        {
            int num = int.Parse(Console.ReadLine());
            int result = 100 / num;
            Console.WriteLine("100/{0} = {1}", num, result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero. Please try again.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Invalid operation. Please try again");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Not a valid format. Please try again.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occured! Please try again.");
        }
    }
}