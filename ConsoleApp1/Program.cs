namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var setInt = new SortedSet<int>() { 5, 1, 4, 2, 3, 2};
            var setString = new SortedSet<string>() { "Maria", "Ioannes", "Baptista", "Maria" };
            foreach ( var item in setInt )
            {
                Console.WriteLine("int - " + item);
            }
            foreach( var item in setString )
            {
                Console.WriteLine("str - " + item);
            }
        }
    }
}