namespace ConsoleApp1
{
    class Program
    {
        delegate void z();
        delegate void calc(int x, int y);
        static void Main(string[] args)
        {
            z z = cl.f;
            z();
            calc calcDelegate = Add;
            calcDelegate(5, 7);
            calcDelegate += Mul;
            calcDelegate.Invoke(12, 13);
            calcDelegate -= Mul;
            calcDelegate.Invoke(12, 13);
        }
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
    }
    public class cl
    {
        static public void f()
        {
            Console.WriteLine("f");
        }
    }
}