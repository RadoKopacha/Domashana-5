namespace Count_NUmbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++) 
            {
                numbers.AddLast(random.Next(100)); 
            }
            Print(numbers);
            int count = Count(numbers);
            Console.WriteLine($"Elements: {count}");
        }
        static void Print(LinkedList<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        static int Count(LinkedList<int> numbers)
        {
            LinkedListNode<int> currNode = numbers.First;
            int count = 0;
            while (currNode != null)
            {
                count++;
                currNode = currNode.Next;
            }
            return count;
        }

    }
}
