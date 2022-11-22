namespace LOCMI.Models.Menu.DemoMenu;

using LOCMI.Controllers;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.DTO;
using LOCMI.Views;

public sealed class TestingAllCommand : IDemoMenuCommand
{
    private readonly List<Certificate> _certificates;

    private readonly CertificateDemonstrationDTO _dto;

    private readonly PromptController _promptController;

    public TestingAllCommand(IView view, List<Certificate> certificates, CertificateDemonstrationDTO certify)
    {
        _certificates = certificates;
        _dto = certify;
        _promptController = new PromptController(view);
    }

    public void Execute()
    {
        _dto.SetCertificates(_certificates);
        _dto.Apply();
        _promptController.Run(_certificates);
        var p = new PrintCommand(_dto);
        p.Execute();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}