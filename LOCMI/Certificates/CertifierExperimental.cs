namespace LOCMI.Certificates;

using LOCMI.Controllers;
using LOCMI.Core;
using LOCMI.Certificates.Tests;

public class CertifierExperimental
{
    private Certificate _certificate;

    private Microcontroller _microController;

    private ITest _test;

    public CertifierExperimental(PromptController promptController)
    {
    }

    public void Apply()
    {
    }

    public void SetMicrocontroller(Microcontroller microController)
    {
        _microController = microController;
    }

    public void SetTest(ITest test)
    {
        _test = test;
    }
}