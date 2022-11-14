namespace LOCMI.Controllers;

using LOCMI.Models.Menu;
using LOCMI.Views;

public abstract class MenuController<T> where T : ICommand
{
    private bool _loop;

    protected MenuController(bool loop)
    {
        _loop = loop;
    }

    public void Run()
    {
        Menu<T> menu = SetMenu();
        do
        {
            
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

        } while (!menu.IsClosed && _loop);
        IView.Clear();
    }

    protected abstract Menu<T> SetMenu();
}