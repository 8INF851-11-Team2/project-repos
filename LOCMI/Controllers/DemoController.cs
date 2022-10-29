using System;
using LOCMI.Models.Menu;
namespace LOCMI.Controllers
{
    public class DemoController
    {
        private View _view;
        private Menu<MenuDemoCommand> _menuDemo;

        public DemoController(View view) => _view = view;

        public void run()
        {
            _menuDemo = new Menu<MenuDemoCommand>("Demonstration Menu");
        }

    }
}

