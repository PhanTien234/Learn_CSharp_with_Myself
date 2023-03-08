namespace Learn_CSharp.FileInfoClass;

public class StreamReaderAndStreamWrite
{
    static void Main(string[] args)
    {
        //Create FileInfo object for DummyFile.txt
        FileInfo fi = new FileInfo(@"D:\DummyFile.txt");
        //Open DummyFile.txt for read operation
        FileStream fsToRead = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        //Open DummyFile.txt for write operation
        FileStream fsToWrite = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        //get the StreamReader
        StreamReader sr = new StreamReader(fsToRead);
        //read all texts using StreamReader object
        string fileContent = sr.ReadToEnd();
        sr.Close();
        //get the StreamWriter
        StreamWriter sw = new StreamWriter(fsToWrite);
        //write some text using StreamWriter
        sw.WriteLine("Another line from streamwriter");
        sw.Close();
        //Close all Stream objects
        fsToRead.Close();
        fsToWrite.Close();
    }
}