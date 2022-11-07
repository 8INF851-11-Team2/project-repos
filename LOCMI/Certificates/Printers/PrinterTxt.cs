namespace LOCMI.Certificates.Printers;

public class PrinterTxt : IPrinter
{
    /// <inheritdoc />
    public void Print(Certificate certificate, string path)
    {
        using StreamWriter writer = File.CreateText(path);

        // TODO
        writer.WriteLine("Certificate");
    }
}