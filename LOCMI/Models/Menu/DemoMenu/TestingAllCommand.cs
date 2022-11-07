namespace LOCMI.Models.Menu.DemoMenu;

using LOCMI.Certificates;

public class TestingAllCommand : IDemoMenuCommand
{
    private readonly List<Certificate> _certificates;

    private readonly CertificateDemonstrationDTO _dto;

    public TestingAllCommand(List<Certificate> certificates, CertificateDemonstrationDTO certify)
    {
        _certificates = certificates;
        _dto = certify;
    }

    public void Execute()
    {
        _dto.SetCertificates(_certificates);
        _dto.Apply();
        PrintCommand p = new PrintCommand(_dto);
        p.Execute();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}