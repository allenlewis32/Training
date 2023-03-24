namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> sd = new SortedDictionary<string, string>();
            sd.Add("d", "dog");
            sd.Add("a", "apple");
            sd.Add("c", "cat");
            sd.Add("b", "ball");
            sd.Add("3", "three");
            sd.Add("1", "one");
            sd.Add("2", "two");
            sd.Remove("3");
            foreach(var kv in sd.OrderBy(x => x.Value))
            {
                if (sd[kv.Key] == "one")
                {
                    sd.Remove(kv.Key);
                }
            }
            foreach(var kv in sd.OrderBy(x => x.Value))
            {
                Console.WriteLine(kv);
            }
            Console.WriteLine();
            foreach(var kv in sd)
            {
                Console.WriteLine(kv);
            }
            Console.WriteLine(sd.GetValueOrDefault("10", "ten"));
        }
    }
}