namespace LOCMI.Models.Menu;

using LOCMI.Certificates;
using LOCMI.Certificates.Printers;
using LOCMI.Controllers;
using LOCMI.Views;

public sealed class PrintCommand : ICommand
{
    private readonly CertificateDemonstrationDTO _certifierDemonstration;

    private readonly IPrinter _printer;

    private CertificateExperimentalDTO _certifierExperimental;

    public PrintCommand(CertificateDemonstrationDTO certifyDemonstration)
    {
        _certifierDemonstration = certifyDemonstration;
        _printer = new PrinterTxt();
    }

    public void Execute()
    {
        string path = "MICROCONTROLEUR_CERTIFICAT.txt";
        IEnumerable<Certificate> c = _certifierDemonstration.GetCertificates();
        _printer.Print(c, path).Wait();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}