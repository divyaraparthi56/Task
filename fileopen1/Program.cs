
using System.IO;
using System.Text;

string fileName = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\fileopen.txt";
FileInfo fi = new FileInfo(fileName);
//File.Open Method

FileStream fs = fi.Open(FileMode.Open, FileAccess.Write);
// If file does not exist, create file
if (!fi.Exists)
{
    //Create the file
    using (FileStream fsi = fi.Create())
    {
        byte[] info = new UTF8Encoding(true).GetBytes("File Start");

        fsi.Write(info, 0, info.Length);
    }
}
try
{
    using (FileStream fsi = fi.Open(FileMode.Open, FileAccess.Write))
    {
        byte[] info = new UTF8Encoding(true).GetBytes("Add more text");
        fs.Write(info, 0, info.Length);
    }
}
catch (Exception Ex)
{
    Console.WriteLine(Ex.ToString());
}
//Append a file

stringfileName = @"C:\Temp\Data\MaheshTXMoved.txt"; 
FileInfofi = newFileInfo(fileName); 
using (StreamWritersw = fi.AppendText())
{
    sw.WriteLine("---------Append Text Start ----------");
    sw.WriteLine("New author started");
    sw.WriteLine("a book on Files Programming ");
    sw.WriteLine("using C#");
    sw.WriteLine("---------Append Text End ----------");
}
// Read all text
string readText = File.ReadAllText(fileName);
Console.WriteLine(readText);
