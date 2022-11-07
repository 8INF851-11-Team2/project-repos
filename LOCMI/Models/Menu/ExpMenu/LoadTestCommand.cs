namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Controllers;
using LOCMI.Certificates;
using LOCMI.Certificates.Tests;

public class LoadTestCommand : IExpMenuCommand
{
    private CertifierExperimental _certifier;

    private ILoader _loader;

    private ScannerController _scannerController;

    private ITest _test;

    public LoadTestCommand() 
    {

    }

    public LoadTestCommand(CertifierExperimental certifier, ScannerController scannerController) 
    {
        _certifier = certifier;
        _scannerController = scannerController;
    }

    public void Execute()
    {
        string path = _scannerController.Run();
        //TODO
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