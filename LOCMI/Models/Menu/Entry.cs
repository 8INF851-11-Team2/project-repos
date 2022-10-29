using System;
namespace LOCMI.Models.Menu
{
    public interface IEntry<T>
    {
        public string Title { get; set; }

        public bool IsExecutable();
        public void Execute();

    }
}

