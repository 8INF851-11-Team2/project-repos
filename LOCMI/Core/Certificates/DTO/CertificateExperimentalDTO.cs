namespace LOCMI.Core.Certificates.DTO;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Microcontrollers;

public sealed class CertificateExperimentalDTO : ICertificateDTO
{
    private List<Certificate> _certificates;
    //TODO
    private Microcontroller _microController;
    public ITest Test { get; set; }

    public CertificateExperimentalDTO()
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

    public void SetMicrocontroller(Microcontroller microController)
    {
        _microController = microController;
    }

    public void SetTest(ITest test)
    {
        Test = test;
    }

}