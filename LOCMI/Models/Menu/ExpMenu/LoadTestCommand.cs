namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Certificates;
using LOCMI.Certificates.Tests;
using LOCMI.Controllers;

public sealed class LoadTestCommand : IExpMenuCommand
{
    private readonly ScannerController _scannerController;

    private CertifierExperimentalDTO _certifier;

    private ILoader _loader;

    private ITest _test;

    public LoadTestCommand()
    {
    }

    public LoadTestCommand(CertifierExperimentalDTO certifier, ScannerController scannerController)
    {
        _certifier = certifier;
        _scannerController = scannerController;
    }

    public void Execute()
    {
        string path = _scannerController.Run();
        //TODO
        //_certifier.SetTest();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }

    public void LCC(CertifierExperimentalDTO certifier, ScannerController scannerController)
    {
    }
}