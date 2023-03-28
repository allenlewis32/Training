using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student() { id = 1, name = "Allen", age = 27, dept = "IT", score = 91 },
                new Student() { id = 2, name = "Lewis", age = 23, dept = "CSE", score = 89 },
                new Student() { id = 3, name = "Rheona", age = 14, dept = "PHY", score = 90 },
                new Student() { id = 4, name = "Patricia", age = 17, dept = "ZOO", score = 92 }
            };
            foreach(var student in students)
            {
                Console.WriteLine($"ID: {student.id}, Name: {student.name}, Age: {student.age}, Dept: {student.dept}, Score: {student.score}");
            }
            Console.WriteLine();
            students.ForEach(x => x.id++);
            List<Student> newStudentList = students.FindAll(x => x.age >= 18);
            newStudentList.Sort((s1, s2) => s1.age - s2.age);
            foreach (var student in newStudentList)
            {
                Console.WriteLine($"ID: {student.id}, Name: {student.name}, Age: {student.age}, Dept: {student.dept}, Score: {student.score}");
            }
        }
    }
    class Student
    {
        public int id;
        public string name;
        public int age;
        public string dept;
        public int score;
    }
}