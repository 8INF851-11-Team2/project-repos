using System;
using LOCMI.Controllers;

namespace LOCMI.Models.Menu
{
    public class MenuDemoCommand : MainMenuCommand
    {
        private DemoController _demoController;

        public MenuDemoCommand(DemoController demoController) => _demoController = demoController;

        public bool isExecutable()
        {
            return false;
        }
        public new void Execute()
        {
            /* TODO */
        }

    }
}