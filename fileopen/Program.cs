//File.Open Method

using System.Text;

FileStream fs = fi.Open(FileMode.Open, FileAccess.Write);
//Here is the complete code
string fileName = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\divya.text";
FileInfo fi = new FileInfo(fileName);
// If file does not exist, create file
if (!fi.Exists)
{
    //Create the file
    .using (FileStream fs = fi.Create())
    {
        Byte[] info = new UTF8Encoding(true).GetBytes("File Start");

        fs.Write(info, 0, info.Length);
    }
}
try
{
    using (FileStream fs = fi.Open(FileMode.Open, FileAccess.Write))
    {
        Byte[] info = newUTF8Encoding(true).GetBytes("Add more text");
        fs.Write(info, 0, info.Length);
    }
}
catch (Exception Ex)
{
    Console.WriteLine(Ex.ToString());
}