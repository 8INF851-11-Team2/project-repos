namespace LOCMI.Models.Menu.ExpMenu;

using System.Drawing;
using LOCMI.Certificates;
using LOCMI.Controllers;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.DTO;
using LOCMI.Core.Loaders;
using LOCMI.Core.Microcontrollers;
using LOCMI.Views;

internal sealed class LoadCertificateCommand : ICommand
{
    private readonly CertificateExperimentalDTO _dto;

    private readonly ILoader<Certificate> _loader;

    private readonly IView _view;

    public LoadCertificateCommand(IView view, CertificateExperimentalDTO dto, ILoader<Certificate> loader)
    {
        _view = view;
        _dto = dto;
        _loader = loader;
    }

    public void Execute()
    {
        _view.Display("Enter Path for Certificate or 'DEFAULT' for Certificate A,B and C");
        string? path = _view.GetUserEntry();

        Certificate? certificate;

        if (path != null && path.Equals("DEFAULT"))
        {
            Microcontroller microcontroller = _dto.Microcontroller;
            Certificate certificateA = new CertificateA(microcontroller);
            Certificate certificateB = new CertificateB(microcontroller);
            Certificate certificateC = new CertificateC(microcontroller);

            _dto.AddCertificate(certificateA);
            _dto.AddCertificate(certificateB);
            _dto.AddCertificate(certificateC);
            _dto.Apply();
            var promptController = new PromptController(_view);
            promptController.Run(_dto.Certificates);
            var p = new PrintCommand(_dto);
            p.Execute();
        }
        else
        {
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

            if (certificate != null)
            {
                certificate.Microcontroller = _dto.Microcontroller;
                _dto.AddCertificate(certificate);
                _dto.Apply();
                var promptController = new PromptController(_view);
                promptController.Run(_dto.Certificates);
                var p = new PrintCommand(_dto);
                p.Execute();
            }
            else
            {
                _view.Display("The certificate has not been loaded", Color.Red);
            }
        }
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}