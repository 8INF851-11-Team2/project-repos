namespace LOCMI.Certificates.Printers;

public interface IPrinter
{
    public async Task Print(IEnumerable<Certificate> certificates, string path)
    {
        foreach (Certificate cert in certificates)
        {
            await Print(cert, path);
        }
    }

    public Task Print(Certificate certificate, string path);
}