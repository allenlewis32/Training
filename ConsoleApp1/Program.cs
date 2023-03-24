namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, char> d = new Dictionary<int, char>();
            d.Add(1, 'a');
            d.Add(2, 'b');
            d.Add(3, 'c');
            d.Add(4, 'd');
            d[5] = 'e';
            d[3] = 'z';
            d.Remove(1);
            foreach(var kv in d)
            {
                if(kv.Value == 'd')
                {
                    d[kv.Key] = 'x';
                }
            }
            Console.WriteLine(d.ContainsValue('c'));
            Console.WriteLine(d.ContainsKey(2));
            foreach(var kv in d)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}