using System;
using LOCMI.Controllers;

namespace LOCMI.Models.Menu
{
    public class MenuExpCommand : MainMenuCommand
    {
        private ExperimentalController _expController;

        public MenuExpCommand(ExperimentalController experimentalController) => _expController = experimentalController;

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