using System;
enum TrafficSignal
{
    RED,
    YELLOW,
    GREEN
}
class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        showTrafficSignal(input);
    }
    static void showTrafficSignal(int color)
    {
        TrafficSignal signal = (TrafficSignal)color;

        switch (signal)
        {
            case TrafficSignal.RED:
                Console.WriteLine("red");
                break;
            case TrafficSignal.YELLOW:
                Console.WriteLine("yellow");
                break;
            case TrafficSignal.GREEN:
                Console.WriteLine("green");
                break;
            default:
                Console.WriteLine("invalid");
                break;
        }
    }
}
