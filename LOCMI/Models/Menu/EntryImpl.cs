using System;
namespace LOCMI.Models.Menu
{
    public class EntryImpl<T> : IEntry<T>
    {
        private string _title;
        private T _command;

        public string Title { get => _title; set => _title = value; }
        public T Command { get => _command; set => _command = value; }


        public void Execute()
        {
           
        }

        public bool IsExecutable()
        {
           return false;
        }

        public void show()
        {
            Console.WriteLine("-----> " + _title);
        }
    }
}

