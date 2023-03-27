using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = "c:\\Users\\HP\\Desktop\\test";
            DirectoryInfo info = new DirectoryInfo(path);
            info.Create();
            info.Delete();
        }
    }
}