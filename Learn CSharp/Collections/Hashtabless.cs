using System.Collections;

namespace Learn_CSharp.Collections;

public class Hashtabless
{
    static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("Key 1", "Value 1");
        hashtable.Add("Key 2", "Value 2");
        Console.WriteLine(hashtable["Key 1"]);
        foreach (DictionaryEntry item in hashtable)
        {
            Console.WriteLine("Key: {0} - value: {1}", item.Key, item.Value);
        }
    }
}