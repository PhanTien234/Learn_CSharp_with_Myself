namespace Learn_CSharp.Dictionarys;

public class CreateDictionaryAndAddElement
{
    static void Main(string[] args)
    {
        IDictionary<int, string> numberNames = new Dictionary<int, string>();
        numberNames.Add(1,"Three");//adding key/value using the Add() method
        numberNames.Add(3,"Three");
        numberNames.Add(2,"Two");
        foreach (KeyValuePair<int, string> kvp in numberNames)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
    //creating a dictionary using collection-initializer syntax
        var cities = new Dictionary<string, string>()
        {
            { "UK", "London, Manchester, Birmingham" },
            { "USA", "Chicago, New York, Washington" },
            { "India", "Mumbai, New Delhi, Pune" }
        };
        foreach (var kvp in cities)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
//The result:
// Key: 1, Value: One
//Key: 3, Value: Three
//Key: 2, Value: Two
//Key: UK, Value: London, Manchester, Birmingham
//Key: USA, Value: Chicago, New York, Washington
//Key: India, Value: Mumbai, New Delhi, Pune