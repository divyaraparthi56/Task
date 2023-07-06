// See https://aka.ms/new-console-template for more information
//file create method
/*
using System.IO;
using System.Text;
string fileName = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\divya.text"; ;
FileInfo fi = new FileInfo(fileName);
try
{
    // Check if file already exists. If yes, delete it.
    if (fi.Exists)
    {
        fi.Delete();
    }// Create a new file
    using (FileStream fsi = fi.Create())
    {
        Byte[] txt = new UTF8Encoding(true).GetBytes("New file.");
        fsi.Write(txt, 0, txt.Length);
        Byte[] author = new UTF8Encoding(true).GetBytes("Author Mahesh Chand");
        fsi.Write(author, 0, author.Length);
    }
    // Write file contents on console.
    using (StreamReader sr = File.OpenText(fileName))
    {
        string s = "";
        while ((s = sr.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
    }
}
catch (Exception Ex)
{
    Console.WriteLine(Ex.ToString());
}


//FileInfo.CreateText Methzzzzz

try
{
    // Check if file already exists. If yes, delete it. 
    if (fi.Exists)
    {
        fi.Delete();
    }
    // Create a new file 
    using (StreamWriter sw = fi.CreateText())
    {
        sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
        sw.WriteLine("Author: Divya");
        sw.WriteLine("divya is a good girl");
        sw.WriteLine("Add one more line ");
        sw.WriteLine("Done! ");
    }
    // Write file contents on console. 
    using (StreamReader sr = File.OpenText(fileName))
    {
        string s = "";
        while ((s = sr.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
    }
}
catch (Exception Ex)
{
    Console.WriteLine(Ex.ToString());
}


//copy

string fileNames = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\divya.text";
FileInfo fis = new FileInfo(fileNames);
string destinationFile = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\fileopen.txt";
try
{
    fis.CopyTo(destinationFile, true);
}
catch (IOException iox)
{
    Console.WriteLine(iox.Message);
}

//write
using System.Text;


string fileName = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\divya.text";
FileInfo fi = new FileInfo(fileName);

using (FileStream fs = fi.OpenWrite())
{
    Byte[] a = new UTF8Encoding(true).GetBytes("Hii, hello welcome to evoke");
    fs.Write(a);
    Byte[] b = new UTF8Encoding(true).GetBytes("Adding more content to the file");
    fs.Write(b);
}


//file replace
string repFile = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\replacedfile.txt";
string backupFile = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\replacedfile.txt.bac"; 
string fileName = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\original.txt";
FileInfo fi = new FileInfo(fileName); 
try
{
    fi.Replace(repFile, backupFile, false);
}
catch (IOException iox)
{
Console.WriteLine(iox.Message);
}

//delete a file
using System.IO;

string fileName = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\delete.txt";
FileInfo fi = new FileInfo(fileName);
try 
{
    fi.Delete(); 
}
catch (IOException iox) 
{
    Console.WriteLine(iox.Message);


//move a file



using System.IO;

string fileName = @"C:\Users\draparthi\Documents\html\move.txt"; 
FileInfo fi = new FileInfo(fileName);
string destinationFile = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\move.txt";
try 
{
    fi.MoveTo(destinationFile);
}
catch (IOException iox) 
{
    Console.WriteLine(iox.Message);
}

//Encrypt a file
using System.IO;
using System.Text.Json.Serialization;

string fileName = @"C:\Users\draparthi\source\repos\FileExamples\bin\Debug\net6.0\move.txt";
FileInfo fi = new FileInfo(fileName);
fi.Encrypt(); 
fi.Decrypt();
*/

//decrypt a file
string fileName = @""; 
FileInfo fi = new FileInfo(fileName); 

fi.Decrypt();





