namespace LOCMI.Models.Menu;

using System.Collections;

public sealed class Menu<T> : IEnumerable<(string, T)> where T : ICommand
{
    private readonly List<(string DisplayText, T Command)> _commands = new ();

    private string _name;

    private T? _selected;

    public Menu(string name)
    {
        _name = name;
    }

    public bool IsClosed { get; } = false;

    public void Add(string text, T command)
    {
        _commands.Add((text, command));
    }

    public void Execute(int userChoice)
    {
        if (userChoice < _commands.Count)
        {
            T command = _commands[userChoice].Command;

            command.Execute();
            _selected = command;
        }
        else
        {
            Console.WriteLine("Please enter a valid choice");
        }
    }

    /// <inheritdoc />
    public IEnumerator<(string, T)> GetEnumerator()
    {
        return _commands.GetEnumerator();
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}