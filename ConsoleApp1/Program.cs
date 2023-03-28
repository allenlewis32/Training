using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        delegate int Calc(int a, int b);
        delegate void Print(string msg);
        static void Main(string[] args)
        {
            Calc add = delegate (int a, int b) { return a + b; };
            Console.WriteLine(add(5, 7));
            Print print = delegate(string msg) { Console.WriteLine(msg); };
            print("Hello");
        }
    }
}