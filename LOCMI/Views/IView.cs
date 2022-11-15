namespace LOCMI.Views;

public interface IView
{
    public void Clear();

    public void Display(string message);

    public string? GetUserEntry();
}