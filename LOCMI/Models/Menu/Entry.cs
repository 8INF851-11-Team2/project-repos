namespace LOCMI.Models.Menu;

public sealed class Entry<T>
{
    private readonly string _title;

    private T _command;

    public Entry(string title, T command)
    {
        _title = title;
        _command = command;
    }

    public void Execute()
    {
        throw new NotImplementedException();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }

    public void Show()
    {
        Console.WriteLine("--------> " + _title);
    }
}