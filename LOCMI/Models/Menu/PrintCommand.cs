namespace LOCMI.Models.Menu;

using LOCMI.Certificates;
using LOCMI.Certificates.Printers;

public sealed class PrintCommand : ICommand
{
    private readonly CertificateDemonstrationDTO _certificateDemonstration;

    private readonly IPrinter _printer;

    public PrintCommand(CertificateDemonstrationDTO certifyDemonstration)
    {
        _certificateDemonstration = certifyDemonstration;
        _printer = new PrinterTxt();
    }

    public void Execute()
    {
        DateTime date = DateTime.Now;
        string path = "CERTIFICATE_" + date.Year + date.Month + date.Day + date.Hour + date.Minute + date.Second + ".txt";
        IEnumerable<Certificate> c = _certificateDemonstration.GetCertificates();
        _printer.Print(c, path).Wait();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}