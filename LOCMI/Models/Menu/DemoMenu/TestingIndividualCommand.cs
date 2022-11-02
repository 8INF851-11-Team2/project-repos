namespace LOCMI.Models.Menu.DemoMenu;

using LOCMI.Models.Certificates;

public class TestingIndividualCommand : IDemoMenuCommand
{
    private readonly Certificate _certificate;

    private readonly CertifyDemonstration _certifyDemonstration;

    public TestingIndividualCommand() { }

    public TestingIndividualCommand(Certificate certificates, CertifyDemonstration certify)
    {
        _certificate = certificates;
        _certifyDemonstration = certify;
    }

    public void Execute()
    {
        var certificates = new List<Certificate> { _certificate };
        _certifyDemonstration.SetCertificates(certificates);
        _certifyDemonstration.Apply();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}