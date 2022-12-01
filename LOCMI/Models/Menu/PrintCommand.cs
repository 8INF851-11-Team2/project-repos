namespace LOCMI.Models.Menu;

using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.DTO;
using LOCMI.Core.Certificates.Printers;

public sealed class PrintCommand : ICommand
{
    private readonly ICertificateDTO _certificateDTO;

    private readonly IPrinter _printer;

    public PrintCommand(ICertificateDTO certificateDTO)
    {
        _certificateDTO = certificateDTO;
        _printer = new PrinterTxt();
    }

    public void Execute()
    {
        DateTime date = DateTime.Now;
        string path = "CERTIFICATE_" + date.Year + date.Month + date.Day + date.Hour + date.Minute + date.Second + ".txt";
        IEnumerable<Certificate> c = _certificateDTO.Certificates;
        _printer.Print(c, path).Wait();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}