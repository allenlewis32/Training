namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Stack:");
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine();
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("Queue:");
            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}