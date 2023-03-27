namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.a();
            ((Ia)c).b();
            c.c();
        }
    }
    public interface Ia
    {
        void a();
        void b()
        {
            Console.WriteLine("ab");
        }
        void c();
    }
    public interface Ib: Ia
    {
        void a();
        void b()
        {
            Console.WriteLine("bb");
        }
    }
    class C : Ib
    {
        public void a()
        {
            Console.WriteLine("ca");
        }
        public void c()
        {
            Console.WriteLine("cc");
        }
    }
}