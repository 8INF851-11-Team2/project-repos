﻿namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Controllers;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.DTO;
using LOCMI.Core.Loaders;
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
        _view.Display("TODO : LOAD OR CREATE CERTIFICATE");
        _view.Display("Enter Path for Certificate");
        string path = _view.GetUserEntry();

        //TODO
        //_certifier.SetTest();

        _view.Display("TODO : DTO");
        //All certificate are created : 

        _dto.Apply();
        var promptController = new PromptController(_view);
        promptController.Run(_dto.GetCertificates());
        var p = new PrintCommand(_dto);
        p.Execute();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}