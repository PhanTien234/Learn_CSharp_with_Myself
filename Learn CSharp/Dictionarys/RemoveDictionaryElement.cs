namespace Learn_CSharp.Dictionarys;

public class RemoveDictionaryElement
{
    static void Main(string[] args)
    {
        var cities = new Dictionary<string, string>()
        {
            { "UK", "London, Manchester, Birmingham" },
            { "USA", "Chicago, New York, Washington" },
            { "India", "Mumbai, New Delhi, Pune" }
        };
        Console.WriteLine("Total Elements: {0}", cities.Count);
        cities.Remove("UK"); //removes UK
        //cities.Remove("France"); //throw run-time exception: KeyNotFoundException
        if (cities.ContainsKey("France"))
        {
            cities.Remove("France");
        }
        Console.WriteLine("Total Elements: {0}", cities.Count);
        cities.Clear(); //deletes all elements
        Console.WriteLine("Total Element after Clear(): {0}", cities.Count);
    }
}
//The result:
//Total Elements: 3
//Total Elements: 2
//Total Elements after Clear(): 0