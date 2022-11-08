namespace LOCMI.Certificates.Printers;

public sealed class PrinterTxt : IPrinter
{
    /// <inheritdoc />
    public async Task Print(Certificate certificate, string path)
    {
        await using StreamWriter file = new (path, true);
        await file.WriteLineAsync("Certificate : " + certificate.Name + '\n' + "Is success : " + certificate.IsSuccess);
    }
}