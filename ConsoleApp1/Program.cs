using System.Threading.Channels;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        ObservableLimitedList list = new(ContainsS);
        list.ListChanged += PrintAdd;
        list.TryAdd("Bruh");
        list.TryAdd("Snake");
        list.PrintAll();
        bool ContainsS(string s)
        {
            if (s.ToLower().Contains("s"))
            {
                return true;
            }
            return false;
        }
        void PrintAdd()
        {
            Console.WriteLine("List Has Changed");
        }
    }
}