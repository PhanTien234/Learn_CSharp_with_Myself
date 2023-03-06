using System.Text;

namespace Learn_CSharp.StringBuilders;

public class InsertStringIntoStringBuilder
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Hello World!", 50);
        sb.Insert(5, " C#");
        Console.WriteLine(sb);
    }
}
//The result: Hello C# World!