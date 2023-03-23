namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var list = new List<string>() { "s1", "s2"};
            list.Add("s3");
            list.Add("s4");
            list.Add("s5");
            list.Remove("s3");
            list.Add("s5");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}