// Pass out parameter in C#
namespace Learn_CSharp.Method;
public class NumberManipulator2 
    {
        public void GetValue(out int x) 
        {
            int temp = 5;
            x = temp;
        }
      
        // static void main(string[] args) 
        // {         
        //     int a;
        //     NumberManipulator2 numberManipulator = new NumberManipulator2();
        //  
        //     /* calling a function to get the value */
        //     numberManipulator.GetValue(out a);
        //
        //     Console.WriteLine("Method call, value of a : {0}", a);
        //     Console.ReadLine();
        // }
    }
    