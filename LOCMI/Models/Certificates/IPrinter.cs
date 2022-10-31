namespace LOCMI.Models.Certificates;

public interface IPrinter
{
    public void Print(List<Certificate> certificates, string path);

    public void Print(Certificate certificate, string path);
}