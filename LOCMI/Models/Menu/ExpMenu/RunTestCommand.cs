namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Certificates;

public sealed class RunTestCommand : IExpMenuCommand
{
    private CertifierExperimentalDTO _certifier;

    public RunTestCommand()
    {
        
    }

    public RunTestCommand(CertifierExperimentalDTO certifier)
    {
        _certifier = certifier;
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