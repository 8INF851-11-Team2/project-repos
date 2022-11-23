namespace LOCMI.Views;

using System.Drawing;

public interface IView
{
    public void Clear();

    public void Display(string message);

    public void Display(string message, Color textColor);

    public void Display(string message, Color textColor, Color backColor);

    public string? GetUserEntry();
}