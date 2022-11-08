namespace LOCMI.Models.Menu;

using LOCMI.Models.Menu.DemoMenu;

public sealed class Entry<T>
{
    private readonly string _title;

    private readonly T _command;

    public Entry(string title, T command)
    {
        _title = title;
        _command = command;
    }

    public void Execute()
    {
        switch (_command)
        {
            case MenuDemoCommand:
                var menuDemo = (MenuDemoCommand) (object) _command;
                menuDemo.Execute();
                break;
            case MenuExpCommand:
                var menuExp = (MenuExpCommand) (object) _command;
                menuExp.Execute();
                break;
            case TestingAllCommand:
                var testingAll = (TestingAllCommand) (object) _command;
                testingAll.Execute();
                break;
            case TestingIndividualCommand:
                var testingIndividual = (TestingIndividualCommand) (object) _command;
                testingIndividual.Execute();
                break;
        }
    }

    public T GetCommand()
    {
        return _command;
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }

    public void Show()
    {
        Console.WriteLine("-------->  " + _title);
    }
}