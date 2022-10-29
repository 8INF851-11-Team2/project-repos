using System;
namespace LOCMI.Models.Menu
{
    public interface ICommand
    {
        public bool IsExecutable();
        public void Execute();
    }
}

