using System;
using LOCMI.Models.Menu;
namespace LOCMI.Controllers
{

    public class ExperimentalController
    {
        private View _view;
        private Menu<MenuExpCommand> _menuExperimental;

        public ExperimentalController(View view) => _view = view;

        public void run()
        {
            _menuExperimental = new Menu<MenuExpCommand>("Experimental Menu");
        }


    }
}