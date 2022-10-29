using System;
namespace LOCMI.Models.Menu
{
    public interface IEntry<T>
    {
        string Title { get; set; }
        T Command { get; set; }
        public bool IsExecutable();
        public void Execute();

        public void show();
    }
}

