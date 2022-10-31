namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Controllers;
using LOCMI.Models.Certificates;

public class LoadTestCommand : ICommand
{
    private CertifierExperimental _certifier;

    private ILoader _loader;

    private ScannerController _scannerController;

    private ITest _test;

    public void Execute()
    {
        throw new NotImplementedException();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }

    public void LCC(CertifierExperimental certifier, ScannerController scannerController)
    {
    }
}