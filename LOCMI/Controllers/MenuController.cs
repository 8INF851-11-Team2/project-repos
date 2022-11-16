namespace LOCMI.Controllers;

using LOCMI.Models.Menu;
using LOCMI.Views;

public abstract class MenuController<T> where T : ICommand
{
    protected readonly IView View;

    private readonly bool _loop;

    private bool _restart;

    protected MenuController(IView view, bool loop)
    {
        View = view;
        _loop = loop;
    }

    public void Run()
    {
        Menu<T> menu = SetMenu();

        do
        {
            _restart = false;
            View.Display("\nChoose a choice from the menu below:");

            var number = 1;

            foreach ((string displayText, _) in menu)
            {
                View.Display($"{number} -------->  {displayText}");
                number++;
            }

            string? read = View.GetUserEntry();

            if (!string.IsNullOrEmpty(read))
            {
                try
                {
                    int userChoice = int.Parse(read);
                    menu.Execute(userChoice - 1);
                }
                catch (Exception e)
                {
                    _restart = true;

                    if (e is ArgumentOutOfRangeException or FormatException)
                    {
                        View.Display("Please enter a valid choice");
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            else
            {
                _restart = true;
            }
        } while ((!menu.IsClosed && _loop) || _restart);

        View.Display("\nEnter anything to continue to main menu:");
        View.GetUserEntry();
        View.Clear();
    }

    protected abstract Menu<T> SetMenu();
}