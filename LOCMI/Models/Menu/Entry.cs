namespace LOCMI.Models.Menu;

public sealed class Entry<T> where T : ICommand
{
    private readonly string _title;

    public Entry(string title, T command)
    {
        _title = title;
        Command = command;
    }

    public T Command { get; }

    public void Execute()
    {
        Command.Execute();
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