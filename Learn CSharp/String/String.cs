namespace Learn_CSharp.String;

public class String{
    public static void Main(string[] args)
    {
        // create string
        string str1 = "C# Programming";
        string str2 = "Programiz";
        //print string 
        Console.WriteLine(str1);
        Console.WriteLine(str2);

        Console.ReadLine();
        
        // get length of str
        int length = str1.Length;
        Console.WriteLine("Length: " + length);
    }
}