namespace LOCMI.Core.Certificates.DTO;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Microcontrollers;

public sealed class CertificateExperimentalDTO : ICertificateDTO
{
    //TODO
    private Microcontroller _microController;

    public CertificateExperimentalDTO()
    {
        Certificates = new List<Certificate>();
    }

    /// <inheritdoc />
    public List<Certificate> Certificates { get; set; }

    public ITest Test { get; set; }

    public void Apply()
    {
        foreach (Certificate certificate in Certificates)
        {
            certificate.Certify();
        }
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