namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Models.Certificates;

public class RunTestCommand : IExpMenuCommand
{
    private CertifierExperimental _certifier;

    public RunTestCommand()
    {

    }
    public RunTestCommand(CertifierExperimental certifier)
    {
    }

    public void Execute()
    {
        throw new NotImplementedException();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}