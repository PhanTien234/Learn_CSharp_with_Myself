namespace Learn_CSharp.Structt;

public class ExStruct
{
    struct Coordinate
            {
                public int x;
                public int y;
            }
    // Create structure without new keyword
    static void Main(string[] args)
    {
        Coordinate point;
        Console.Write(point.x); //Compile time error
        point.x = 10;
        point.y = 20;
        Console.Write(point.x); // output: 10;
        Console.Write(point.y); // output: 20;
    }
    //create struct with new keyword
    static void Main(string[] args)
    {
        Coordinate point = new Coordinate();
        Console.WriteLine(point.x); //output: 0
        Console.WriteLine(point.y); //output: 0
    }
}
  