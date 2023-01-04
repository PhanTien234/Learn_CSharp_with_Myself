namespace Learn_CSharp.Variable;

public class InstanceVariable
{
    // These variables are instance variables.
    // These variables are in a class and
    // are not inside any function
    int engMarks;
    int mathsMarks;
    int phyMarks;
 
    // Main Method
    public static void Main(String[] args)
    {
         
        // first object
        InstanceVariable obj1 = new InstanceVariable();
        obj1.engMarks = 90;
        obj1.mathsMarks = 80;
        obj1.phyMarks = 93;
 
        // second object
        InstanceVariable obj2 = new InstanceVariable();
        obj2.engMarks = 95;
        obj2.mathsMarks = 70;
        obj2.phyMarks = 90;
 
        // displaying marks for first object
        Console.WriteLine("Marks for first object:");
        Console.WriteLine(obj1.engMarks);
        Console.WriteLine(obj1.mathsMarks);
        Console.WriteLine(obj1.phyMarks);
 
        // displaying marks for second object
        Console.WriteLine("Marks for second object:");
        Console.WriteLine(obj2.engMarks);
        Console.WriteLine(obj2.mathsMarks);
        Console.WriteLine(obj2.phyMarks);
    }
}