namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Controllers;
using LOCMI.Core.Certificates;
using LOCMI.Core.Loaders;
using LOCMI.Core.Microcontrollers;
using LOCMI.Views;

public sealed class LoadMicrocontrollerCommand : IExpMenuCommand
{
    private readonly CertificateExperimentalDTO _certifier;

    private readonly ILoader<Microcontroller> _loader;

    private readonly ScannerController _scannerController;

    private readonly IView _view;

    public LoadMicrocontrollerCommand()
    {
    }

    public LoadMicrocontrollerCommand(IView view, CertificateExperimentalDTO certifier, ScannerController scannerController)
    {
        _view = view;
        _scannerController = scannerController;
        _certifier = certifier;
    }

    public void Execute()
    {
        string path = _scannerController.Run();

        Microcontroller? microcontroller;

        try
        {
            microcontroller = _loader.Load(path);
        }
        catch (LoadException ex)
        {
            _view.Display(ex.Message);

            if (ex.InnerException != null)
            {
                _view.Display(ex.InnerException.Message);
            }

            return;
        }

        if (microcontroller != null)
        {
            _certifier.SetMicrocontroller(microcontroller);
        }
        else
        {
            _view.Display("The microcontroller has not been loaded");
        }
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}