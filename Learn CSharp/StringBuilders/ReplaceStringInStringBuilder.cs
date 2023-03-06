using System.Text;

namespace Learn_CSharp.StringBuilders;

public class ReplaceStringInStringBuilder
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Hello World!!", 50);
        sb.Replace("World", "C#");
        Console.WriteLine(sb);
    }
}
// The result: Hello C#!!