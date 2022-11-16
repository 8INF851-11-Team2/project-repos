namespace LOCMI.Core.Certificates;

public sealed class CertificateDemonstrationDTO
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