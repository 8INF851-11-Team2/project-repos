namespace LOCMI.Core.Certificates.DTO;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Microcontrollers;

public sealed class CertificateExperimentalDTO : ICertificateDTO
{
    public CertificateExperimentalDTO()
    {
        Certificates = new List<Certificate>();
    }

    /// <inheritdoc />
    public List<Certificate> Certificates { get; set; }

    public Microcontroller? Microcontroller { get; set; }

    public ITest? Test { get; set; }

    public void AddCertificate(Certificate certificate)
    {
        Certificates.Add(certificate);
    }

    public void Apply()
    {
        foreach (Certificate certificate in Certificates)
        {
            certificate.Certify();
        }
    }
}