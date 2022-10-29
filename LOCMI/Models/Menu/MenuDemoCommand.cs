using System;
using LOCMI.Controllers;

namespace LOCMI.Models.Menu
{
    public class MenuDemoCommand : MainMenuCommand
    {
        private DemoController _demoController;

        public bool isExecutable()
        {
            return false;
        }
        public void execute()
        {

        }

    }
}