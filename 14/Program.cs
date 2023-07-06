using System;
Console.WriteLine("enter number of subjects:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter total marks");
int total = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter subject marks{0}", i+1);
    sum = sum + Convert.ToInt32(Console.ReadLine());
}
int percentage = (sum / total) * 100;
Console.WriteLine("Enter subjects:");
string[] subjects = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Subject Names{0}", i+1);
    subjects[i] = Console.ReadLine();
}
if (percentage > (total * 0.75))
{
    Console.WriteLine("A grade");
}
else if ((percentage < (total * 0.75)) && (percentage > (total * 0.60)))
{
    Console.WriteLine("B grade");
}
else if ((percentage < (total * 0.60)) && (percentage > (total * 0.50)))
{
    Console.WriteLine("C grade");
}
else
{
    Console.WriteLine("D grade");
}
