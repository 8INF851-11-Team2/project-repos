namespace LOCMI.Models.Menu;

using LOCMI.Certificates;
using LOCMI.Certificates.Printers;
using LOCMI.Controllers;
using LOCMI.Views;

public sealed class PrintCommand : ICommand
{
    private readonly CertificateDemonstrationDTO? _certificateDemonstration;

    private readonly IPrinter _printer;

    private CertificateExperimentalDTO? _certifierExperimental;

    public PrintCommand(CertificateDemonstrationDTO certifyDemonstration)
    {
        _certificateDemonstration = certifyDemonstration;
        _printer = new PrinterTxt();
    }

    public void Execute()
    {
        DateTime date = DateTime.Now;
        string path = "MICROCONTROLEUR_CERTIFICAT" + date.Year + date.Month + date.Day + date.Hour + date.Minute + date.Second + ".txt";
        IEnumerable<Certificate> c = _certificateDemonstration.GetCertificates();
        _printer.Print(c, path).Wait();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}