namespace Learn_CSharp.Structt;

public class MethodsAndPropertiesInStruct
{
    struct Coordinate
    {
        public int x { set; get; }
        public int y { set; get; }

        public void SetOrigin()
        {
            this.x = 0;
            this.y = 0;
        }
    }

    static void Main(string[] args)
    {
        Coordinate point = new Coordinate();
        point.SetOrigin();
        Console.WriteLine(point.x); //output: 0;
        Console.WriteLine(point.y); //output: 0;
    }
}