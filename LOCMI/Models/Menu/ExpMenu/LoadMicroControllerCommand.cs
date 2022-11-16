namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Certificates;
using LOCMI.Controllers;
using LOCMI.Core.Microcontrollers;

public sealed class LoadMicrocontrollerCommand : IExpMenuCommand
{
    private readonly CertificateExperimentalDTO _certifier;

    private readonly ScannerController _scannerController;

    private ILoader _loader;

    public LoadMicrocontrollerCommand()
    {
    }

    public LoadMicrocontrollerCommand(CertificateExperimentalDTO certifier, ScannerController scannerController)
    {
        _scannerController = scannerController;
        _certifier = certifier;
    }

    public void Execute()
    {
        string path = _scannerController.Run();
        Microcontroller microcontroller = _loader.LoadController(path);
        _certifier.SetMicrocontroller(microcontroller);
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}