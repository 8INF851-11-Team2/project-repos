namespace LOCMI.Controllers;

using LOCMI.Models.Menu;
using LOCMI.Views;

public abstract class MenuController<T> where T : ICommand
{
    protected readonly View View;

    protected MenuController(View view)
    {
        View = view;
    }

    public void Run()
    {
        Menu<T> menu = SetMenu();

        while (!menu.IsClosed)
        {
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
        }
    }

    protected abstract Menu<T> SetMenu();
}