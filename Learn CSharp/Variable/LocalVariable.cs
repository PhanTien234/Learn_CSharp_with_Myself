namespace Learn_CSharp.Variable;
// The local variable
public class LocalVariable
{
    // Method
    public void StudentAge()
    {
         
        // local variable age
        int age = 0;
         
        age = age + 10;
        Console.WriteLine("Student age is : " + age);
    }
 
    // Main Method
    public static void Main(String[] args)
    {
         
        // Creating object
        LocalVariable obj = new LocalVariable();
         
        // calling the function
        obj.StudentAge();
    }
}