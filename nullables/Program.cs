// See https://aka.ms/new-console-template for more information
using MiscEx;

Console.WriteLine("Hello, World!");
int? x = null;
string emp = null;
int? empno = null;

Class1 cls = null;

if (cls != null)
    Console.WriteLine(cls.MyProperty);

if (emp is null)
{

}

emp = null;
emp = string.Empty;
if (string.IsNullOrEmpty(emp))
{
    Console.WriteLine("hi");

}

