namespace Learn_CSharp.Method;

public class CallMethodInCsharp
{

        public int FindMax(int num1, int num2) 
        {
            return num1 > num2 ? num1 : num2;
        }
      
        static void Main(string[] args) 
        {
            int a = 100, b = 200;
            CallMethodInCsharp n = new CallMethodInCsharp();

            //calling the FindMax method
            int result = n.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", result);
            Console.ReadLine();
        }
}