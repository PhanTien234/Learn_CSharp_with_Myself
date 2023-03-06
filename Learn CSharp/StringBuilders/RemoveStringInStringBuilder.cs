using System.Text;

namespace Learn_CSharp.StringBuilders;

public class RemoveStringInStringBuilder
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Hello World!", 50);
        sb.Remove(6, 7);
        Console.WriteLine(sb);
    }
}
//The result: Hello