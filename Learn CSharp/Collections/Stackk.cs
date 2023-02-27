using System.Collections;

namespace Learn_CSharp.Collections;

public class Stackk
{
    static void Main(string[] args)
    {
        //Creates and initialize a new Stack
        Stack myStack = new Stack();
        myStack.Push("Hello");
        myStack.Push("World");
        myStack.Push("!");
        // Displays the properties and values of the Stack
        Console.WriteLine("myStack");
        Console.WriteLine("\t Count: {0}", myStack.Count);
        Console.Write("\tValues: ");
        foreach (Object obj in myStack)
        {
            Console.Write("     {0}", obj);
        }
    }
}
//Result: 
//Count: 3
// Values: !  World   Hello