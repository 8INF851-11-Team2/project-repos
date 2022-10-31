namespace LOCMI.Controllers;

using LOCMI.Models.Menu;
using LOCMI.Views;

public sealed class DemoController
{
    private Menu<MenuDemoCommand> _menuDemo;

    private View _view;

    public DemoController(View view)
    {
        _view = view;
    }

    public void Run()
    {
        _menuDemo = new Menu<MenuDemoCommand>("Demonstration Menu");
    }
}