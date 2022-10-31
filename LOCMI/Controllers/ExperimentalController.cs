namespace LOCMI.Controllers;

using LOCMI.Models.Menu;
using LOCMI.Models.Menu.ExpMenu;
using LOCMI.Views;

public sealed class ExperimentalController
{
    private Menu<MenuExpCommand> _menuExperimental;

    private View _view;

    public ExperimentalController(View view)
    {
        _view = view;
    }

    public void Run()
    {
        _menuExperimental = new Menu<MenuExpCommand>("Experimental Menu");
    }
}