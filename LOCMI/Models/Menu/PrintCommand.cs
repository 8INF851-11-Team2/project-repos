namespace LOCMI.Models.Menu;

using LOCMI.Certificates;
using LOCMI.Certificates.Printers;
using LOCMI.Controllers;
using LOCMI.Views;

public sealed class PrintCommand : ICommand
{
    private readonly CertificateDemonstrationDTO _certifierDemonstration;

    private readonly IPrinter _printer;

    private readonly ScannerController _scannerController;

    private CertifierExperimental _certifierExperimental;

    public PrintCommand(CertificateDemonstrationDTO certifyDemonstration)
    {
        _certifierDemonstration = certifyDemonstration;
        _printer = new PrinterTxt();
        _scannerController = new ScannerController(new View());
    }

    public void Execute()
    {
        string path = _scannerController.Run();
        IEnumerable<Certificate> c = _certifierDemonstration.GetCertificates();
        _printer.Print(c, path).Wait();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}