namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fun1("Allen");
            Fun2("Allen", 2);
        }
        static void Fun1(string name)
        {
            Console.WriteLine($"Name: {name}");
        }
        static void Fun2(string name, int id)
        {
            Console.WriteLine($"Name: {name}\nID: {id}");
        }
    }
}