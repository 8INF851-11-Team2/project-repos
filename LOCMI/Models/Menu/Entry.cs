namespace LOCMI.Models.Menu;

using LOCMI.Models.Menu.DemoMenu;

public sealed class Entry<T>
{
    private readonly string _title;

    private T _command;

    public Entry(string title, T command)
    {
        _title = title;
        _command = command;
    }

    public void Execute()
    {
        switch(_command)
        {
            case MenuDemoCommand:
                MenuDemoCommand menuDemo = (MenuDemoCommand) (object) _command;
                menuDemo.Execute();
                break;
            case MenuExpCommand:
                MenuExpCommand menuExp = (MenuExpCommand) (object) _command;
                menuExp.Execute();
                break;
            case TestingAllCommand:
                TestingAllCommand testingAll = (TestingAllCommand) (object) _command;
                testingAll.Execute();
                break;
            case TestingIndividualCommand:
                TestingIndividualCommand testingIndividual = (TestingIndividualCommand) (object) _command;
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