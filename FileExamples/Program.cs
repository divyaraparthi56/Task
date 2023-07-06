// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
File.Create("divya.txt");
if (File.Exists("divya.txt"))
{
    Console.WriteLine("Hi divya..file created");
}
else
{
    Console.WriteLine("File modified");
}
using (StreamWriter writer = new StreamWriter(Path.GetFullPath("divya.text")))
{
    writer.WriteLine("divya");
    writer.WriteLine("lavanya");
    writer.WriteLine("navya");
    writer.WriteLine("pallavi");
    writer.WriteLine("mythili");
}
// Read a file
string readText = File.ReadAllText(Path.GetFullPath("divya.text"));
Console.WriteLine(readText);