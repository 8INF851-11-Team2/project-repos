namespace LOCMI.Models.Menu;

public sealed class Entry<T> where T : ICommand
{
    private readonly T _command;

    private readonly string _title;

    public Entry(string title, T command)
    {
        _title = title;
        _command = command;
    }

    public void Execute()
    {
        _command.Execute();
    }

    public T GetCommand()
    {
        return _command;
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }

    public void Show()
    {
        Console.WriteLine("-------->  " + _title);
    }
}