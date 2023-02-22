namespace Learn_CSharp.TypeCovert;

public static void Main(string[] args)
{
    //TH1: Kieu nho hon (int) => lon hon (long)
    int intValue1 = 10;
    long longValue1 = intValue1;
    Console.WriteLine("Truong hop 1: " + longValue1);
    //TH2: Kieu lon => nho (se xay ra loi)
    long longValue2 = 99999999999999;
    int inValue2 = longValue2;
    Console.WriteLine(inValue2);
}