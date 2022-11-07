namespace LOCMI.Certificates.Printers;

public class PrinterTxt : IPrinter
{
    /// <inheritdoc />
    public async void Print(Certificate certificate, string path)
    {
        using StreamWriter file = new(path, append: true);
        await file.WriteLineAsync("Certificate : " + certificate.Name + '\n' + "Is success : " + certificate.IsSuccess);
    }
}