using System;
namespace add_2nums_15_06_23
{
    public class Addi
    {
        public static void Main(string[] args)
        {
            Add func = new Add();
            Console.WriteLine("enter first number");
            int a = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("the sum of 2 numbers is {0}", func.sum(a, b));

        }
    }
}


