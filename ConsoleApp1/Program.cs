using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("c:\\Users\\HP\\Desktop\\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs.Write(Encoding.ASCII.GetBytes("Hello"));
            fs.Close();

            fs = new FileStream("c:\\Users\\HP\\Desktop\\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fs);
            Console.WriteLine(streamReader.ReadToEnd());
            fs.Close();
        }
    }
}