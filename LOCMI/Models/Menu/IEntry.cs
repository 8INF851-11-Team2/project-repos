namespace LOCMI.Models.Menu;

public interface IEntry<T>
{
    T Command { get; set; }

    string Title { get; set; }

    public void Execute();

    public bool IsExecutable();

    public void Show();
}