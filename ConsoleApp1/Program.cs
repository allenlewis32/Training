using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var add = (int a, int b) => a + b;
            var sub = (int a, int b) => a - b;
            Console.WriteLine(add(5, 7));
            Console.WriteLine(sub(5, 7));
            var print = (string msg) => Console.WriteLine(msg);
            print("Hello");
            var stack = add + sub;
            foreach(var d in stack.GetInvocationList())
            {
                Console.WriteLine(d.DynamicInvoke(1, 2));
            }
        }
    }
}