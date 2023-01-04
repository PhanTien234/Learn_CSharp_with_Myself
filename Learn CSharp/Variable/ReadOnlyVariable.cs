namespace Learn_CSharp.Variable;

public class ReadOnlyVariable
{
    // instance variable
        int a = 80;
         
        // static variable
        static int b = 40;
     
        // Constant variables
        const float max = 50;
         
        // readonly variables
        readonly int k;
     
        // Main Method
        public static void Main()
        {
             
            // Creating object
            ReadOnlyVariable obj = new ReadOnlyVariable();
             
            Console.WriteLine("The value of a is = " + obj.a);
            Console.WriteLine("The value of b is = " + ReadOnlyVariable.b);
            Console.WriteLine("The value of max is = " + ReadOnlyVariable.max);
            Console.WriteLine("The value of k is = " + obj.k);
        }
}