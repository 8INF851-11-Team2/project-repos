using System;

namespace LOCMI.Models.Menu
{
    public class Menu<T>
    {
        private string _name;
        private Boolean _isClosed;
        private List<IEntry<T>> entries;
        private ICommand _selectionned;

        public Menu(string name)
        {
            _name = name;
            _isClosed = false;
            entries = new List<IEntry<T>>();
        }

        public List<IEntry<T>> GetEntries()
        {
            return entries;
        }

        public Boolean getIsClosed()
        {
            return _isClosed;
        }

        public void Add(string text, T command)
        {
            IEntry<T> entry = new EntryImpl<T>();
            entry.Title = text;
            entry.Command = command;
            entries.Add(entry);
        }

        public void Execute(int userChoice) 
        {
            if (userChoice < entries.Count)
            {
                entries[userChoice].Execute();
            }
            else
                Console.WriteLine("Please enter a valid choice");
        }
    }
}