using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        string name;
        int age, rollno, id;
        Marks marks;
        public Student(string name, int age, int rollno, int id, Marks marks)
        {
            this.name = name;
            this.age = age;
            this.rollno = rollno;
            this.id = id;
            this.marks = marks;
        }
        public float GetPercent()
        {
            marks.calculatePercent();
            return marks.percent;
        }
    }
    public class Marks
    {
        int totalMarks;
        public float percent;
        int noSubjects;
        public void calculatePercent()
        {
            percent = (float)totalMarks / noSubjects;
        }
        public Marks(int totalMarks, int noSubjects)
        {
            this.totalMarks = totalMarks;
            this.noSubjects = noSubjects;
        }
    }
}
