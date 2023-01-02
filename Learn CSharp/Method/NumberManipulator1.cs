// Pass reference parameter in C#
namespace Learn_CSharp.Method;
public class NumberManipulator1
{
    public void Swap(ref int a, ref int b)
    {
        int temp;

        temp = a; /* save the value of a */
        a = b; /* put b into a */
        b = temp; /* put temp into b */
    }

    static void main(string[] args)
    {
        NumberManipulator1 n = new NumberManipulator1();

        /* local variable definition */
        int a = 100;
        int b = 200;

        Console.WriteLine("Before swap, value of a : {0}", a);
        Console.WriteLine("Before swap, value of b : {0}", b);

        /* calling a function to swap the values */
        n.Swap(ref a, ref b);

        Console.WriteLine("After swap, value of a : {0}", a);
        Console.WriteLine("After swap, value of b : {0}", b);

        Console.ReadLine();
    }
}

