// Call Method by Recursive
namespace Learn_CSharp.Method;
public class CallMethodByRecursive
{
    public int Factorial(int num) 
    {
        int result;
        if (num == 1) 
        {
            return 1;
        } 
        else 
        {
            result = Factorial(num - 1) * num;
            return result;
        }
    }
  
    // static void Main(string[] args) 
    // {
    //     CallMethodByRecursive n = new CallMethodByRecursive();
    //  
    //     Console.WriteLine("Factorial of 7 is : {0}", n.Factorial(7));
    //     Console.ReadLine();
    // }
}