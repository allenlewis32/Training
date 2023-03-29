using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        delegate void Print();
        static void Main(string[] args)
        {
            Print print = HelloWorld;
            print();
            Action<string> p = (msg) => Console.WriteLine(msg);
            p("Action");
            Func<int, int> abs = (x) => x >= 0 ? x : -x;
            Console.WriteLine(abs(5));
            Console.WriteLine(abs(-7));
        }
        public static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}