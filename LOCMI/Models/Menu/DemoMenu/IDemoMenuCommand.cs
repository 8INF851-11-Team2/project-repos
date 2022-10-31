using System;
namespace LOCMI.Models.Menu.DemoMenu
{
    public interface IDemoMenuCommand
    {
        public void Execute();
        public bool IsExecutable();
    }
}

