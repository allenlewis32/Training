namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Volvo volvo = new();
            volvo.start();
            Console.WriteLine("Max speed: " + volvo.GetMaxSpeed());
            volvo.stop();
            volvo.ABS();
            Car c = volvo;
            c.ABS();
        }
    }
}