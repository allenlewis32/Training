class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 0;
        try
        {
            int c = a / b;
            Console.WriteLine(c);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Exception Caught: {ex.Message}");
        }
    }
}