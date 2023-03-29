using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            M1();
            M2();
            int n = await returnNumber();
            Console.WriteLine(n);
            Console.ReadLine();
        }
        static Task<int> returnNumber()
        {
            return Task.Run(() =>
            {
                Task.Delay(1000);
                return 5;
            });
        }
        static async void M1()
        {
            Console.WriteLine("M1 started");
            await Task.Delay(1000);
            Console.WriteLine("M1 ended");
        }
        static void M2()
        {
            Console.WriteLine("M2 started");
            Console.WriteLine("M2 ended");
        }
    }
}