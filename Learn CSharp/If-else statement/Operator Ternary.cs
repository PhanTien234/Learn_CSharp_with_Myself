namespace Learn_CSharp.If_else_statement;

public static void Main(String[] args)
{
    int i= Int32.Parse(Console.ReadLine());
    string result = (i < 23) ? "the number less than 23" : "the number more than 23";
    Console.WriteLine(result);
}