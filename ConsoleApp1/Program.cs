namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            C1 c1 = new C1();c1.Foo();
            C2 c2 = new C2();c2.Foo();
        }
    }
    class C1
    {
        public virtual void Foo()
        {
            Console.WriteLine("C1");
        }
    }
    class C2: C1
    {
        public sealed override void Foo()
        {
            Console.WriteLine("C2");
        }
    }
}