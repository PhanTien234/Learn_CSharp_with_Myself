namespace Learn_CSharp.FileInfoClass;

public class ReadFileUSingStreamReader
{
    static void Main(string[] args)
    {
        //Create object of FileInfo for specified path
        FileInfo fi = new FileInfo(@"D:\DummyFile.txt");
        //OPen file for Read/Write
        FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
        //Create object of StreamReader by passing FileStream object on which it needs to operates on
        StreamReader sr = new StreamReader(fs);
        //Use ReadToEnd method to read all the content from file
        string fileContent = sr.ReadToEnd();
        //Close Streamreader object after operation
        sr.Close();
        fs.Close();
    }
}