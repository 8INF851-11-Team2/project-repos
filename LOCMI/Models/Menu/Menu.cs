namespace LOCMI.Models.Menu;

public sealed class Menu<T>
{
    private readonly List<Entry<T>> _entries;

    private bool _isClosed;

    private string _name;

    private T _selected;

    public Menu(string name)
    {
        _name = name;
        _isClosed = false;
        _entries = new List<Entry<T>>();
    }

    public void Add(string text, T command)
    {
        var entry = new Entry<T>(text, command);

        _entries.Add(entry);
    }

    public void Execute(int userChoice)
    {
        if (userChoice < _entries.Count)
        {
            _entries[userChoice].Execute();
            _selected = _entries[userChoice].GetCommand();
        }
        else
        {
            Console.WriteLine("Please enter a valid choice");
        }
    }

    public List<Entry<T>> GetEntries()
    {
        return _entries;
    }

    public bool GetIsClosed()
    {
        return _isClosed;
    }
}