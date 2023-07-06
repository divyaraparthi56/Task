
/// <summary>
/// This is multai tasking example1
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Method1();
        Method2();
        Method3();
        Console.ReadKey();
    }

    public static async Task Method1()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                if(i%2 == 0)
                Console.WriteLine(" Even Number " + i);
                // Do something
                Task.Delay(1000).Wait();
            }
        });
    }


    public static async void Method2()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                if(i%2!=0)
                Console.WriteLine("--Odd number-- " + i);
                // Do something
                Task.Delay(1000).Wait();
            }

        });
    }
    public static async void Method3()
    {
        await Task.Run(() =>
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(a + b);
            Task.Delay(1000).Wait();
        });

    }


}
