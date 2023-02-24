namespace Learn_CSharp.Array;

public class SomeOfWayToCreateArray
{
    static void Main(string[] args)
    {
        //create an array have the length of 4, add more element after created;
        string[] cars = new string[4];
        //create an array have the length of 4, add element while create;
        string[] cars = new [4] { "Honda", "Toyota", "Peague", "Tesla" };
        //create an array not need specific index of element
        string[] cars = new[] { "Honda", "Toyata", "Tesla" };
        
        //create an array not need specific index of element and not need key word: new
        string[] cars = { "Honda", "Toyata", "Ford" };
        //Declare an array and initialize it by keyword: new
        string[] cars;
        cars = new string[] { "Honda", "Toyota" };
        //If not keyword: new, the array will be errol
        cars = {"Honda", "BMW"}
        ;
    }
}