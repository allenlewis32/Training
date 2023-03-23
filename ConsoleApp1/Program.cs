namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var set = new HashSet<int>() { 1, 2, 3, 2};
            set.Add(4);
            set.Add(1);
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}