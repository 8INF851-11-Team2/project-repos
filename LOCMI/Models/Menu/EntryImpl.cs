namespace LOCMI.Models.Menu;

public sealed class EntryImpl<T> : IEntry<T>
{
    public T Command { get; set; }

    public string Title { get; set; }

    public void Execute()
    {
    }

    public bool IsExecutable()
    {
        return false;
    }

    public void Show()
    {
        Console.WriteLine("-----> " + Title);
    }
}