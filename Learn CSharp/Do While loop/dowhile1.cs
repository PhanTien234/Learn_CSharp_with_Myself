namespace Learn_CSharp.Do_While_loop;

public class dowhile1
{
    static void Main(string[] args)
    {
        int a = 1;
        int sum = 0;
        do
        {
            sum += a;
            a++;
        } while (a <= 5); 
        Console.WriteLine("Sum of 1 to 5 is: " + sum);
    }
}