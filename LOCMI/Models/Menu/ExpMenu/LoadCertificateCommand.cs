namespace LOCMI.Models.Menu.ExpMenu;

using System.Drawing;
using LOCMI.Controllers;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.DTO;
using LOCMI.Core.Loaders;
using LOCMI.Core.Microcontrollers;
using LOCMI.Views;

internal sealed class LoadCertificateCommand : ICommand
{
    private readonly CertificateExperimentalDTO _dto;

    private readonly IView _view;

    private ILoader<Certificate> _loader;

    public LoadCertificateCommand(IView view, CertificateExperimentalDTO dto, ILoader<Certificate> loader)
    {
        _view = view;
        _dto = dto;
        _loader = loader;
    }

    public void Execute()
    {
        _view.Display("Enter Path for Certificate");
        string? path = _view.GetUserEntry();

        Certificate? certificate;

        try
        {
            certificate = _loader.Load(path);
        }
        catch (LoadException ex)
        {
            _view.Display(ex.Message, Color.Red);

            if (ex.InnerException != null)
            {
                _view.Display(ex.InnerException.Message, Color.Red);
            }

            return;
        }

        if(certificate != null)
        {
            certificate.Microcontroller = _dto.GetMicrocontroller();
            _dto.AddCertificate(certificate);
            _dto.Apply();
            var promptController = new PromptController(_view);
            promptController.Run(_dto.Certificates);
            var p = new PrintCommand(_dto);
            p.Execute();
        }
        else
        {
            _view.Display("The microcontroller has not been loaded", Color.Red);
        }
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}