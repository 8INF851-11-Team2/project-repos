namespace LOCMI.Models.Menu;

public sealed class Menu<T>
{
    private readonly List<IEntry<T>> _entries;

    private readonly bool _isClosed;

    private string _name;

    private ICommand _selected;

    public Menu(string name)
    {
        _name = name;
        _isClosed = false;
        _entries = new List<IEntry<T>>();
    }

    public void Add(string text, T command)
    {
        IEntry<T> entry = new EntryImpl<T>
        {
            Title = text, Command = command,
        };

        _entries.Add(entry);
    }

    public void Execute(int userChoice)
    {
        if (userChoice < _entries.Count)
        {
            _entries[userChoice].Execute();
        }
        else
        {
            Console.WriteLine("Please enter a valid choice");
        }
    }

    public List<IEntry<T>> GetEntries()
    {
        return _entries;
    }

    public bool GetIsClosed()
    {
        return _isClosed;
    }
}