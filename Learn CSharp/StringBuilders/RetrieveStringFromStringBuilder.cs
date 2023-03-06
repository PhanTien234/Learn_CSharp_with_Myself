using System.Text;

namespace Learn_CSharp.StringBuilders;

public class RetrieveStringFromStringBuilder
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Hello World!");
        var greet = sb.ToString();
        Console.WriteLine(greet);
    }
}