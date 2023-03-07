namespace Learn_CSharp.HandlingException;

public class NestedTryCatchBlock
{
    static void Main(string[] args)
    {
        Student std = null;
        var divider = 0;
        try
        {
            try
            {
                var result = 100 / divider;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Inner catch");
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Outer catch");
        }
    }
}

public class Student
{
    public string StudentName { get; set; }
}