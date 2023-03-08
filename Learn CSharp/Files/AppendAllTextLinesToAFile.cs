namespace Learn_CSharp.Files;

public class AppendAllTextLinesToAFile
{
    static void Main(string[] args)
    {
        string dummyLines = "This is first line." + Environment.NewLine +
                            "This is second line." + Environment.NewLine +
                            "This is third line.";
        //Opens DummyFile.txt and append lines. If file is not exists then create and open.
        File.AppendAllLines(@"C:\DummyFile.txt", dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());
    }
}