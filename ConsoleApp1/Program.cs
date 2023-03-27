namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Marks marks = new(475, 5);
            Student student = new("AL", 23, 1, 2, marks);
            Console.WriteLine("Percentage: " + student.GetPercent() + "%");
        }
    }
}