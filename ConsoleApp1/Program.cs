class Program
{
    string name;
    int id;
    string dept;
    float grade;
    
    Program(string name, int id, string dept, float grade)
    {
        this.name = name;
        this.id = id;
        this.dept = dept;
        this.grade = grade;
    }
    ~Program()
    {
        Console.WriteLine("Destructor Called");
    }
    static void Main(string[] args)
    {
        Program program = new Program("Allen Lewis", 2, "IT", 9.2f);
        Program program2 = new Program("Maria Ioannes Baptista", 7, "CS", 9.7f);
        program.PrintDetails();
        program2.PrintDetails();
    }
    void PrintDetails()
    {
        Console.WriteLine($"Name: {name}\nID: {id}\nDept: {dept}\nGrade: {grade:0.00}\n");
    }
}