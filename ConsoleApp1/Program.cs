using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = "c:\\Users\\HP\\Desktop\\test.txt";
            using(TextWriter writer = File.CreateText(path))
            {
                writer.Write("Test\nefw");
            }
            using(TextReader reader = File.OpenText(path))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}