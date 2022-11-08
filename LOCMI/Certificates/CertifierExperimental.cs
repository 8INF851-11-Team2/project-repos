namespace LOCMI.Certificates;

using LOCMI.Certificates.Tests;
using LOCMI.Core;

public class CertifierExperimental
{
    private Certificate _certificate;

    private Microcontroller _microController;

    public ITest Test { get; set; }

    public void Apply()
    {
    }

    public void SetMicrocontroller(Microcontroller microController)
    {
        _microController = microController;
    }
}