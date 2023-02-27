using System.Collections;

namespace Learn_CSharp.Collections;

public class Queuee
{
    static void Main(string[] args)
    {
        //Creates and initializes a new Queue
        Queue myQ = new Queue();
        myQ.Enqueue("Hello");
        myQ.Enqueue("World");
        myQ.Enqueue("!");
        //Display the properties and values of the Queue
        Console.WriteLine(myQ);
        Console.WriteLine("\tCount: {0}", myQ.Count);
        Console.WriteLine("\tValues: ");
        foreach (Object obj in myQ)
        {
            Console.Write("        {0}", obj);
        }
    }
}
// Result:
// Count: 3
// Values: Hello World !