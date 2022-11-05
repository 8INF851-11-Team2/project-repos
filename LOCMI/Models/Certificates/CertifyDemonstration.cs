namespace LOCMI.Models.Certificates;

using LOCMI.Controllers;

public class CertifyDemonstration
{
    private List<Certificate> _certificates;

    private PromptController _promptController;

    public CertifyDemonstration()
    {
        _certificates = new List<Certificate>();
    }

    public void Apply()
    {   
        foreach (Certificate certi in _certificates)
        {
            /* TODO */
        }
    }

    public List<Certificate> GetCertificates()
    {
        return _certificates;
    }

    public void SetCertificates(List<Certificate> certificates)
    {
        _certificates = certificates;
    }
}