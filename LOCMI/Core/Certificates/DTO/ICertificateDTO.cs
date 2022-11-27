namespace LOCMI.Core.Certificates.DTO;

public interface ICertificateDTO
{
    public void Apply();

    public List<Certificate> GetCertificates();
}
