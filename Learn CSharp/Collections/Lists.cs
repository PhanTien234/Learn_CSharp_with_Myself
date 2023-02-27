using System.Collections;

namespace Learn_CSharp.Collections;

public class Lists
{
    // Compare the level of the safety for security between ArrayList and List
    static void Main(string[] args)
    {
        ArrayList arrayList1 = new ArrayList();
        arrayList1.Add(1);
        arrayList1.Add("Pony"); //<- No error at complie process
        int total = 0;
        foreach (int num in arrayList1)
        {
            total += num; //<- Runtime Error
        }
    }
    
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>();
        list1.Add(1);
        //list1.Add("Pony"); // <-Errol at complie process
        int total = 0;
        foreach (int num in list1)
        {
            total += num;
        }
    }
    
    
}