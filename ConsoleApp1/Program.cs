using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = "c:\\Users\\HP\\Desktop\\test.txt";
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Create();
        }
    }
}