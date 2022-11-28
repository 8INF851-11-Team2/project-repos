namespace LOCMI.Core.Certificates.DTO;

public sealed class CertificateDemonstrationDTO : ICertificateDTO
{
    public CertificateDemonstrationDTO()
    {
        Certificates = new List<Certificate>();
    }

    /// <inheritdoc />
    public List<Certificate> Certificates { get; set; }

    public void Apply()
    {
        foreach (Certificate certificate in Certificates)
        {
            certificate.Certify();
        }
    }
}