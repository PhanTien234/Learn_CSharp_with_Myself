namespace Learn_CSharp.FileInfoClass;

public class WriteTextsToFileUSingStreamWriter
{
    static void Main(string[] args)
    {
        //Create object of FIleInfo for specified path
        FileInfo fi = new FileInfo(@"D:\DummyFile.txt");
        //Open file for Read/Write
        FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
        //Create StreamWriter object to write string to FileStream
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("Another line from streamwriter");
        sw.Close();
    }
}