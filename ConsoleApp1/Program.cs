using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of subjects: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks: ");
            int[] marks = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                marks[i] = Convert.ToInt32(input[i]);
            }
            float cgpa = CalculateCGPA(marks);
        }
        public static float CalculateCGPA(int[] marks)
        {
            if(marks.Any(x => x > 100))
            {
                throw new Exception("Mark greater than max mark");
            }
            int n = marks.Length;
            int total = marks.Sum();
            float average = (float)total / n;
            float cgpa = average / 10;
            Console.WriteLine($"Average: {average:0.##}");
            Console.WriteLine($"CGPA: {cgpa:0.##}");
            return cgpa;
        }
    }
}