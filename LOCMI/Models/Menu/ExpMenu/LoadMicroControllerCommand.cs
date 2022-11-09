namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Certificates;
using LOCMI.Controllers;
using LOCMI.Core;

public sealed class LoadMicrocontrollerCommand : IExpMenuCommand
{
    private readonly CertifierExperimental _certifier;

    private readonly ScannerController _scannerController;

    private ILoader _loader;

    public LoadMicrocontrollerCommand()
    {
    }

    public LoadMicrocontrollerCommand(CertifierExperimental certifier, ScannerController scannerController)
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