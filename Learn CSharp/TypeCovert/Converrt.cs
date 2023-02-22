namespace Learn_CSharp.TypeCovert;

public class Converrt
{
    public static void Main(string[] args)
    {
        int num = "69";
        string resultTrue1 = "True";
        string resultTrue2 = "Dung roi";
        var convert1 = Convert.ToString(num);
        // Mot cach khac su dung phuong thuc cua kieu du lieu
        // var convert = num.ToString();
        var convert2 = Convert.ToBoolean(resultTrue1);
        
        //Them dong nay se bi loi
        var convert3 = Convert.ToBoolean(resultTrue2);
        Console.WriteLine("Ket qua 1: " + convert1);
        Console.WriteLine("Ket qua 2: " + convert2);
        Console.WriteLine("Ket qua 2: " + convert3);
    }
}