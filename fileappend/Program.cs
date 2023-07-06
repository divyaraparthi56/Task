using System.IO;

string fileName = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\divya.text";
FileInfo fi = new FileInfo(fileName);
using (StreamWriter sw = fi.AppendText())
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

//copy

string fileName = @"C:\Temp\MaheshTXFITx.txt";
FileInfo fi = new FileInfo(fileName); 
string destinationFile = @"C:\Temp\Data\MaheshTXCopied.txt"; 
try 
{
    fi.CopyTo(destinationFile, true);
}
catch(IOException iox)
{
    Console.WriteLine(iox.Message);
}