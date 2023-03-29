using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var f = ReadFile("c:\\Users\\HP\\a.txt");
            string msg = await f;
            Console.WriteLine(msg);
        }
        static Task<string> ReadFile(string path)
        {
            var task = Task.Run(() =>
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader r = new StreamReader(fs);
                string contents = r.ReadToEnd();
                return contents;
            });
            Console.WriteLine("File opened");
            return task;
        }
    }
}