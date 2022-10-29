using System;
using LOCMI.Controllers;

namespace LOCMI.Models.Menu
{
    public class MenuExpCommand : MainMenuCommand
    {
        private ExperimentalController _expController;

        public bool isExecutable()
        {
            return false;
        }
        public void execute()
        {

        }
    }
}