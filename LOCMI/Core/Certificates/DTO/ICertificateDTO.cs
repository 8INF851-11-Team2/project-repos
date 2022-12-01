namespace LOCMI.Core.Certificates.DTO;

public interface ICertificateDTO
{
    public List<Certificate> Certificates { get; set; }

    public void Apply();
}