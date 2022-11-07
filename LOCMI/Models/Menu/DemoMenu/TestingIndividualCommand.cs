namespace LOCMI.Models.Menu.DemoMenu;

using LOCMI.Certificates;

public class TestingIndividualCommand : IDemoMenuCommand
{
    private readonly Certificate _certificate;

    private readonly CertificateDemonstrationDTO _dto;

    public TestingIndividualCommand(Certificate certificates, CertificateDemonstrationDTO certify)
    {
        _certificate = certificates;
        _dto = certify;
    }

    public void Execute()
    {
        var certificates = new List<Certificate> { _certificate };
        _dto.SetCertificates(certificates);
        _dto.Apply();
        foreach (Certificate cert in certificates)
        {
            Console.WriteLine(cert.Name + " : " + cert.IsSuccess);
        }
        PrintCommand p = new PrintCommand(_dto);
        p.Execute();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}