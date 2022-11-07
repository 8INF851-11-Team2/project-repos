namespace LOCMI.Models.Menu;

using LOCMI.Controllers;
using LOCMI.Certificates;
using LOCMI.Certificates.Printers;

public class PrintCommand : ICommand
{
    private readonly CertifyDemonstration _certifierDemonstration;

    private CertifierExperimental _certifierExperimental;

    private IPrinter _printer;

    private ScannerController _scannerController;

    public PrintCommand(CertifyDemonstration certifyDemonstration)
    {
        _certifierDemonstration = certifyDemonstration;
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