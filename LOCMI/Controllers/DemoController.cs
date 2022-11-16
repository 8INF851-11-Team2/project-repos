namespace LOCMI.Controllers;

using LOCMI.Certificates;
using LOCMI.Core.Certificates;
using LOCMI.Core.Microcontrollers;
using LOCMI.Microcontrollers;
using LOCMI.Models.Menu;
using LOCMI.Models.Menu.DemoMenu;
using LOCMI.Views;

public sealed class DemoController : MenuController<IDemoMenuCommand>
{
    public DemoController(IView view)
        : base(view, false)
    {
    }

    /// <inheritdoc />
    protected override Menu<IDemoMenuCommand> SetMenu()
    {
        List<Certificate> certificates = CreateListCertificates();

        var certificateDemonstrationDTO = new CertificateDemonstrationDTO();

        var testingAllCommand = new TestingAllCommand(View, certificates, certificateDemonstrationDTO);
        var testingIndividualCommand = new TestingIndividualCommand(View, certificateDemonstrationDTO);

        return new Menu<IDemoMenuCommand>("Demonstration Menu")
        {
            { "Testing All", testingAllCommand },
            { "Testing Individual", testingIndividualCommand },
        };
    }

    private static List<Certificate> CreateListCertificates()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        var certificates = new List<Certificate>
        {
            new CertificateA(microcontrollerA),
            new CertificateA(microcontrollerB),
            new CertificateA(microcontrollerC),
            new CertificateB(microcontrollerA),
            new CertificateB(microcontrollerB),
            new CertificateB(microcontrollerC),
            new CertificateC(microcontrollerA),
            new CertificateC(microcontrollerB),
            new CertificateC(microcontrollerC),
        };

        return certificates;
    }
}