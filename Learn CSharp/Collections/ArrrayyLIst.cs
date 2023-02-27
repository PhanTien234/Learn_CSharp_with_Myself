using System.Collections;

namespace Learn_CSharp.Collections;

public class ArrrayyLIst
{
    static void Main(string[] args)
    {
        ArrayList arrayList1 = new ArrayList();
        ArrayList arrayList2 = new ArrayList();
        arrayList1.Add("Item 1");
        arrayList1.Add("Item 2");
        arrayList1.Add("Item 3");
        arrayList1.Add("Item 4"); //Item 1, Item 2, Item 3, Item 4.
        arrayList2.Add("Item ArrayList 2"); //Item ArrayList 2
        arrayList1.AddRange(arrayList2); //Item 1, Item 2, Item 3, Item 4, Item ArrayList 2
        arrayList1.Insert(2, "New Item");//Item 1, Item 2, New Item, Item 3, Item 4, Item Array 2
        for (var i = 0; i < arrayList1.Count; i++)
        {
            Console.WriteLine(arrayList1[i]);
        }
    }
}