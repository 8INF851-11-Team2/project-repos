namespace LOCMI.Models.Menu;

public class Entry<T>
{
    private string _title;
    private T _command;

    public Entry(string title, T command)
    {
        _title = title;
        _command = command;
    }

    public bool isExecutable()
    {
        throw new NotImplementedException();
    }

    public void Execute()
    {
        throw new NotImplementedException();
    }

    public void Show()
    {
        Console.WriteLine("--------> " + _title);
    }
}