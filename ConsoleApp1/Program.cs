using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> g = (a, b) => (a > b);
            Predicate<int> p = (a) => (a > 5);
        }
    }
}