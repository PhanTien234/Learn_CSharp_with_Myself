using System.Text;

namespace Learn_CSharp.StringBuilders;

public class StringBuilderIteration
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Hello World!!");
        for(int i = 0; i < sb.Length; i++)
            Console.Write(sb[i]);
    }
    
}
//The result: Hello World!!