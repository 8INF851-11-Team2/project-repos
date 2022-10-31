using System;
namespace LOCMI.Models.Menu.ExpMenu
{
    public interface IExpMenuCommand
    {
        public void Execute();
        public bool IsExecutable();
    }
}

