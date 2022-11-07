namespace LOCMI.Certificates.Printers;

public interface IPrinter
{
    public void Print(List<Certificate> certificates, string path)
    {
        foreach (Certificate cert in certificates)
        {
            Print(cert, path);
        }
    }

    public void Print(Certificate certificate, string path);
}