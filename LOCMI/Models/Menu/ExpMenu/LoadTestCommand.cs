namespace LOCMI.Models.Menu.ExpMenu;

using LOCMI.Controllers;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.DTO;
using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Loaders;
using LOCMI.Views;

public sealed class LoadTestCommand : IExpMenuCommand
{
    private readonly CertificateExperimentalDTO _dto;

    private readonly ILoader<ITest> _loader;

    private readonly IView _view;

    private ITest _test;

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
        string? path = _view.GetUserEntry();
        //TODO
        //_certifier.SetTest();

        //Next Step
        ILoader<Certificate> loader = LoaderUtils.GetSameLoader<Certificate, ITest>(_loader);
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