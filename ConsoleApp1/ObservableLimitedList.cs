namespace ConsoleApp1;

public class ObservableLimitedList
{

    private List<string> _list = new List<string>();
    public event Action ListChanged;
    private Predicate<string> _predicate;
    public ObservableLimitedList(Predicate<string> predicate)
    {
        _predicate = predicate;
    }
    public bool TryAdd(string s)
    {
        if (_predicate.Invoke(s))
        {
            _list.Add(s);
            ListChanged?.Invoke();
            return true;
        }
        return false;
    }
    public void PrintAll()
    {
        foreach (var item in _list)
        {
            Console.WriteLine(item);
        }
    }
}