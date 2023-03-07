namespace Learn_CSharp.Dictionarys;

public class UpdateDictionaryElements
{
    static void Main(string[] args)
    {
        var cities = new Dictionary<string, string>()
        {
            { "UK", "London, Manchester, Birmingham" },
            { "USA", "Chicago, New York, Washington" },
            { "India", "Mumbai, New Delhi, Pune" }
        };
        cities["UK"] = "Liverpool, Bristol"; //update value of UK key
        cities["USA"] = "Los Angeles, Boston"; //update value of USA key
        //cities["France"] = "Paris"; //Throws run-time exception: KeyNotFoundException
        if (cities.ContainsKey("France"))
        {
            cities["France"] = "Paris";
        }

        foreach (var kvp in cities)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
//The result:
//Key: USA, Value: Liverpool, Bristol
//Key: USA, Value: Los Angeles, Boston
//Key: India, Value: Mumbai, New Delhi, Pune