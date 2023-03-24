namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ll = new LinkedList<int>();
            ll.AddLast(1);
            ll.AddLast(2);
            ll.AddLast(3);
            ll.AddLast(4);
            ll.AddLast(5);
            ll.AddLast(6);
            ll.AddLast(4);
            foreach(var node in FindNext(ll, 4))
            {
                ll.AddBefore(node, 10);
            }
            foreach(var n in ll)
            {
                Console.WriteLine(n);
            }
        }
        static IEnumerable<LinkedListNode<int>> FindNext(LinkedList<int> ll, int value)
        {
            LinkedListNode<int>? node = ll.First;
            while (node != null)
            {
                if (node.Value == value)
                {
                    yield return node;
                }
                node = node.Next;
            }
        }
    }
}