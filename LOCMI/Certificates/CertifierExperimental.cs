namespace LOCMI.Certificates;

using LOCMI.Certificates.Tests;
using LOCMI.Controllers;
using LOCMI.Core;

public class CertifierExperimentalDTO
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

    public void SetTest(ITest Test)
    {
        this.Test = Test;
    }

    public void Certifier(PromptController promptController)
    {

    }

}