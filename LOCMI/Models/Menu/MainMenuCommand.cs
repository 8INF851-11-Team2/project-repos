using System;
using LOCMI.Controllers;

namespace LOCMI.Models.Menu
{
    public abstract class MainMenuCommand : ICommand
    {

        protected InitialController controller;
        public bool IsExecutable()
        {
            return false;
        }
        public void Execute()
        {

        }
    }
}