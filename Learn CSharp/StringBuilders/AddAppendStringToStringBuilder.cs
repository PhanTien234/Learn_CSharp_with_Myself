using System.Text;

namespace Learn_CSharp.StringBuilders;

public class AddAppendStringToStringBuilder
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("World!");
        sb.AppendLine("Hello C#!");
        sb.AppendLine("This is new line. ");
        Console.WriteLine(sb);
    }
}
//The result:
//Hello World! Hello C#!
//This is new line