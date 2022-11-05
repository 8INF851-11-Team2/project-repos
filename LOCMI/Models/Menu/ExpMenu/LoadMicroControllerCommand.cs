namespace LOCMI.Models.Menu.ExpMenu;
using LOCMI.Models.Certificates;
using LOCMI.Controllers;
using LOCMI.Core;
public class LoadMicroControllerCommand : IExpMenuCommand
{
    private CertifierExperimental _certifier;
    
    private ScannerController _scannerController;

    private ILoader _loader;

    public LoadMicroControllerCommand()
    {
        
    }

    public LoadMicroControllerCommand(CertifierExperimental certifier, ScannerController scannerController) 
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