namespace LOCMI.Core.Certificates.DTO;

public sealed class CertificateDemonstrationDTO : ICertificateDTO
{
    private List<Certificate> _certificates;

    public CertificateDemonstrationDTO()
    {
        _certificates = new List<Certificate>();
    }

    public void Apply()
    {
        foreach (Certificate certificate in _certificates)
        {
            certificate.Certify();
        }
    }

    public IEnumerable<Certificate> GetCertificates()
    {
        return _certificates;
    }

    public void SetCertificates(List<Certificate> certificates)
    {
        _certificates = certificates;
    }
}