namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            CL<string> ct = new CL<string>("Message");
            CL<int> ct2 = new CL<int>(7);
            Test("GM");
            Test(23);
        }
        public static void Test<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class CL<T>
    {
        public CL(T message)
        {
            Console.WriteLine(message);
        }
    }
}