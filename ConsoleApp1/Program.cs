using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Task t1 = M1();
            Task t2 = M2();
            Task t3 = Task.WhenAll (t1, t2);
            await t3;
            M3();
        }
        static void M3() { Console.WriteLine("M3"); }
        static async Task M1()
        {
            Console.WriteLine("M1 in");
            await Task.Delay(2000);
            Console.WriteLine("M1 out");
        }
        static async Task M2()
        {
            Console.WriteLine("M2 in");
            await Task.Delay(1000);
            Console.WriteLine("M2 out");
        }
    }
}