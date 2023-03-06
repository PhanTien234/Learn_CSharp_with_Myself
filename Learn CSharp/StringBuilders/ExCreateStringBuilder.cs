using System.Text;

namespace Learn_CSharp.StringBuilders;

public class ExCreateStringBuilder
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder(); //string will be appended later
        //or
        StringBuilder sb = new StringBuilder("Hello World!");
        // or use overloaded constructors
        StringBuilder sb = new StringBuilder(50); // string will be appended later
        // or
        StringBuilder sb = new StringBuilder("Hello World!", 50);

    }
}