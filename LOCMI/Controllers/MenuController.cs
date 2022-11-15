namespace LOCMI.Controllers;

using LOCMI.Models.Menu;
using LOCMI.Views;

public abstract class MenuController<T> where T : ICommand
{
    private bool _loop;
    private bool _restart = false;

    protected MenuController(bool loop)
    {
        _loop = loop;
    }

    public void Run()
    {
        Menu<T> menu = SetMenu();
        do
        {
            _restart = false;
            IView.Display("\nChoose a choice from the menu below:");

            var number = 1;

            foreach ((string displayText, _) in menu)
            {
                IView.Display($"{number} -------->  {displayText}");
                number++;
            }

            string? read = IView.GetUserEntry();

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
                        IView.Display("Please enter a valid choice");                        
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

        IView.Display("\nEnter anything to continue to main menu:");
        IView.GetUserEntry();
        IView.Clear();
    }

    protected abstract Menu<T> SetMenu();
}