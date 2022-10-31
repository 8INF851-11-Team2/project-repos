namespace LOCMI.Models.Menu.DemoMenu;

using LOCMI.Models.Certificates;

public class TestingAllCommand : IDemoMenuCommand
{
    private readonly List<Certificate> _certificates;

    private readonly CertifyDemonstration _certify;

    public TestingAllCommand(List<Certificate> certificates, CertifyDemonstration certify)
    {
        _certificates = certificates;
        _certify = certify;
    }

    public void Execute()
    {
        _certify.SetCertificates(_certificates);
        _certify.Apply();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}