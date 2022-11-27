namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Controllers;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.DTO;
using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Loaders;
using LOCMI.Core.Microcontrollers;
using LOCMI.Views;

public sealed class LoadTestCommand : IExpMenuCommand
{
    private CertificateExperimentalDTO _dto;

    private readonly ILoader<ITest> _loader;

    private ITest _test;

    private readonly IView _view;


    public LoadTestCommand(IView view, CertificateExperimentalDTO dto, ILoader<ITest> loader)
    {
        _view = view;
        _dto = dto;
        _loader = loader;
    }

    public void Execute()
    {
        _view.Display("TODO : LOAD TEST || Vérifier avec AF si on doit aussi laisser la possibilité de crée des tests");
        _view.Display("Enter Path for Test");
        string path = _view.GetUserEntry();
        //TODO
        //_certifier.SetTest();


        //Next Step
        ILoader<Certificate> loader = LoadersUtils.GetSameLoader<Certificate, ITest>(_loader);
        var command = new LoadCertificateCommand(_view, _dto, loader);
        command.Execute();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }

    public void LCC(CertificateExperimentalDTO certifier, ScannerController scannerController)
    {
    }
}