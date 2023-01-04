namespace Learn_CSharp.Variable;

public class ConstantVariable
{
    // instance variable
    int a = 10;
     
    // static variable
    static int b = 20;
 
    // constant variable
    const float max = 50;
 
    // Main Method
    public static void Main()
    {
         
        // creating object
        ConstantVariable obj = new ConstantVariable();
         
        // displaying result
        Console.WriteLine("The value of a is = " + obj.a);
        Console.WriteLine("The value of b is = " + ConstantVariable.b);
        Console.WriteLine("The value of max is = " + ConstantVariable.max);
    }
}