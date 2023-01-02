// Pass Value Parameter in C#
namespace Learn_CSharp.Method;

public class NumberManipulator
{
    public void Swap(int a, int b) 
        {
            int temp;
         
            temp = a; /* save the value of a */
            a = b;    /* put b into a */
            b = temp; /* put temp into b */
        }
      
        static void Main(string[] args) 
        {
            NumberManipulator n = new NumberManipulator();
         
            /* local variable definition */
            int a = 100;
            int b = 200;
         
            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);
         
            /* calling a function to swap the values */
            n.Swap(a, b);
         
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
         
            Console.ReadLine();
        }
    

}
