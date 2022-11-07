namespace LOCMI.Models.Menu;

using LOCMI.Controllers;
using LOCMI.Certificates;
using LOCMI.Certificates.Printers;
using LOCMI.Views;

public class PrintCommand : ICommand
{
    private readonly CertificateDemonstrationDTO _certifierDemonstration;

    private CertifierExperimental _certifierExperimental;

    private IPrinter _printer;

    private ScannerController _scannerController;

    public PrintCommand(CertificateDemonstrationDTO certifyDemonstration)
    {
        _certifierDemonstration = certifyDemonstration;
        _printer = new PrinterTxt();
        _scannerController = new ScannerController(new View());
    }

    public void Execute()
    {
        string path = _scannerController.Run();
        List<Certificate> c = _certifierDemonstration.GetCertificates();
        _printer.Print(c, path);
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}