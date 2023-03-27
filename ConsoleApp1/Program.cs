namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            C1 c = new C2();
            c.M1();c.M2();
            C2 c2 = new();
            c2.M1(); c2.M2();
        }
    }
    abstract class C1
    {
        public abstract void M1();
        public void M2()
        {
            Console.WriteLine("M2");
        }
    }
    class C2: C1
    {
        public override void M1()
        {
            Console.WriteLine("M1");
        }
    }
}