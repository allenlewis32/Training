namespace ConsoleApp1
{
    class Program
    {
        delegate void z();
        delegate int calc(int x, int y);
        static void Main(string[] args)
        {
            z z = cl.f;
            z(); 
            calc calcDelegate = Add;
            Console.WriteLine(calcDelegate(5, 7));
            calcDelegate += Mul;
            Console.WriteLine(calcDelegate.Invoke(12, 13));
            calcDelegate -= Mul;
            Console.WriteLine(calcDelegate.Invoke(12, 13));

            calcDelegate = Add;
            calcDelegate += Mul;
            foreach(calc calc in calcDelegate.GetInvocationList())
            {
                Console.WriteLine(calc.Invoke(5, 7));
            }
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Mul(int x, int y)
        {
            return x * y;
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