namespace Learn_CSharp.Variable;

public class StaticVariable
{
    // static variable salary
    static double salary;
    static String name = "Aks";
 
    // Main Method
    public static void Main(String[] args)
    {
 
        // accessing static variable
        // without object
        StaticVariable.salary = 100000;
         
        Console.WriteLine(StaticVariable.name + "'s average salary:"
                                   + StaticVariable.salary);
    }
}