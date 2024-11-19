namespace Zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Rado", "Mecho", "Tedo", "Mitko", "Vylchan" };
            LinkedList<string> list = new LinkedList<string>(names);
            Finder(list);
        }
        static void Finder(LinkedList<string> list)
        {
            Console.Write("Which guy do you search for:");

            
            string search = Console.ReadLine();
            if (list.Contains(search))
            {
                Console.WriteLine($"It has the name: {search}!");
            }
            else
            {
                Console.WriteLine($"It doesnt have the name: {search}!");
            }
        }
    }
}
