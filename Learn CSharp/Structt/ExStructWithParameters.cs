namespace Learn_CSharp.Structt;

public class ExStructWithParameters
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
    }

    static void Main(string[] args)
    {
        Coordinate point = new Coordinate(10, 20);
        Console.WriteLine(point.x); //output 10
        Console.WriteLine(point.y); //output 20
    }
}