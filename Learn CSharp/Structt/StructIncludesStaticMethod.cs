namespace Learn_CSharp.Structt;

public class StructIncludesStaticMethod
{
    struct Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Coordinate GetOrigin()
        {
            return new Coordinate();
        }
    }

    static void Main(string[] args)
    {
        Coordinate point = Coordinate.GetOrigin();
        Console.WriteLine(point.x); //output: 0
        Console.WriteLine(point.y); //output: 0
    }
}