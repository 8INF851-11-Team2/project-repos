using System;

namespace LOCMI.Models.Menu
{
    public class Menu<T>
    {
        private string _name;
        private Boolean _isClosed;

        public Menu(string name) => _name = name;
        public List<IEntry<T>> GetEntries()
        {
            /* TODO */
            List<IEntry<T>> entries = new List<IEntry<T>>();
            return entries;
        }

        public void Add(string text, T command)
        {

        }
        public void Execute(int userChoice)
        {

        }
    }
}