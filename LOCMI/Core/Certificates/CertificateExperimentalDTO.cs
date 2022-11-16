namespace LOCMI.Core.Certificates;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Microcontrollers;

public class CertificateExperimentalDTO
{
    private Certificate _certificate;

    private Microcontroller _microController;

    public ITest Test { get; set; }

    public void Apply()
    {
    }

    public void Certifier()
    {
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