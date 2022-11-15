namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Certificates;

public sealed class RunTestCommand : IExpMenuCommand
{
    private CertificateExperimentalDTO _certifier;

    public RunTestCommand()
    {
    }

    public RunTestCommand(CertificateExperimentalDTO certifier)
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