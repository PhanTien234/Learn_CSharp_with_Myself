namespace Learn_CSharp.If_else_statement;

public static void Main(String[] args)
{
    int i= Int32.Parse(Console.ReadLine());
    if (i < 23)
    {
        Console.WriteLine("The number less than 23");
    }else if (i > 23)
    {
        Console.WriteLine("the number more than 23");
    }
    else
    {
        Console.WriteLine("As as");
    }
}
