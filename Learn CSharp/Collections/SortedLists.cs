using System.Collections;

namespace Learn_CSharp.Collections;

public class SortedLists
{
    static void Main(string[] args)
    {
        SortedList mySL = new SortedList();
        mySL.Add("Third","!");
        mySL.Add("Second","World");
        mySL.Add("First", "Hello");
        //Displays the properties and values of the SortedList
        Console.WriteLine("mySL");
        Console.WriteLine("Count: {0}", mySL.Count);
        Console.WriteLine("Capacity: {0}", mySL.Capacity);
        Console.WriteLine("Keys and Values: ");
        Console.WriteLine("\t - KEY- \t - VALUE -");
        for (int i = 0; i < mySL.Count; i++)
        {
            Console.WriteLine("\t {0}: \t {1}", mySL.GetKey(i), mySL.GetByIndex(i));
        }
    }
}