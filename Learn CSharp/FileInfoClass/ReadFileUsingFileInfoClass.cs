using System.Text;

namespace Learn_CSharp.FileInfoClass;

public class ReadFileUsingFileInfoClass
{
    static void Main(string[] args)
    {
        //Create object of FileInfo for specified path
        FileInfo fi = new FileInfo(@"D:\DummyFile.txt");
        //Open file for Read/Write
        FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        //create byte array of same size as FileStream length
        byte[] fileBytes = new byte[fs.Length];
        //Define counter to check how much bytes to read. Decrease the counter as you read each byte
        int numBytesToRead = (int)fileBytes.Length;
        //Counter to indicate number of bytes already read
        int numBytesRead = 0;
        //iterate till all the bytes read from FileStream
        while (numBytesToRead > 0)
        {
            int n = fs.Read(fileBytes, numBytesRead, numBytesToRead);
            if(n==0)
                break;
            numBytesRead += n;
            numBytesToRead -= n;
        }
        //Once you read all the bytes from FileStream, you can convert it into string using UTF8 encoding
        string filestring = Encoding.UTF8.GetString(fileBytes);
    }
}