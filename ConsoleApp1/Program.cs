class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            CheckAge(age);
        }
        catch (MyException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void CheckAge(int age)
    {
        if(age < 18)
        {
            throw new MyException("Must be atleast 18 to vote");
        }
        Console.WriteLine("You can Vote");
    }
    class MyException:Exception
    {
        public MyException(string msg):base(msg) { }
    }
}