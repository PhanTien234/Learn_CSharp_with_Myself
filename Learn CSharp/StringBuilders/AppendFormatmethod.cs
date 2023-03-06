using System.Text;

namespace Learn_CSharp.StringBuilders;

public class AppendFormatmethod
{
    static void Main(string[] args)
    {
        StringBuilder amountMsg = new StringBuilder("Your total amount is ");
        amountMsg.AppendFormat("{0:C} ", 25);
        Console.WriteLine(amountMsg);
    }
}