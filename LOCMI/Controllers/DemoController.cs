namespace LOCMI.Controllers;

using LOCMI.Certificates;
using LOCMI.Certificates.Tests;
using LOCMI.Certificates.Tests.TestCases;
using LOCMI.Core;
using LOCMI.Microcontrollers;
using LOCMI.Models.Menu;
using LOCMI.Models.Menu.DemoMenu;
using LOCMI.Views;
using static System.Net.Mime.MediaTypeNames;

public sealed class DemoController : MenuController<IDemoMenuCommand>
{
    public DemoController()
        :base(false)
    {
    }

    /// <inheritdoc />
    protected override Menu<IDemoMenuCommand> SetMenu()
    {
        var certificates = CreateListCertificates();


        var certificateDemonstrationDTO = new CertificateDemonstrationDTO();

        var testingAllCommand = new TestingAllCommand(certificates, certificateDemonstrationDTO);
        var testingIndividualCommand = new TestingIndividualCommand(certificateDemonstrationDTO);

        return new Menu<IDemoMenuCommand>("Demonstration Menu")
        {
            { "Testing All", testingAllCommand },
            { "Testing Individual", testingIndividualCommand },
        };
    }

    private List<Certificate> CreateListCertificates()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        //Certificate
        var certificateA1 = CreateCertificateA(microcontrollerA);
        var certificateA2 = CreateCertificateA(microcontrollerB);
        var certificateA3 = CreateCertificateA(microcontrollerC);
        var certificateB1 = CreateCertificateB(microcontrollerA);
        var certificateB2 = CreateCertificateB(microcontrollerB);
        var certificateB3 = CreateCertificateB(microcontrollerC);
        var certificateC1 = CreateCertificateC(microcontrollerA);
        var certificateC2 = CreateCertificateC(microcontrollerB);
        var certificateC3 = CreateCertificateC(microcontrollerC);

        var certificates = new List<Certificate>
        {
            certificateA1, certificateA2, certificateA3,
            certificateB1, certificateB2, certificateB3,
            certificateC1, certificateC2, certificateC3,
        };

        return certificates;
    }

    private Certificate CreateCertificateA(Microcontroller mc)
    {
        //Init TestSuite
        ITest testA = new ElectronicVersatilityTest(new[] { 3.3, 5 });
        var suiteA = new TestSuite();
        suiteA.AddTest(testA);

        var certificateA = new Certificate(suiteA, mc, "CertificateA");
        return certificateA;
    }
    private Certificate CreateCertificateB(Microcontroller mc)
    {
        //Init TestSuite
        ITest testA = new HasHardDiskTest();
        var suiteA = new TestSuite();
        suiteA.AddTest(testA);

        var certificateB = new Certificate(suiteA, mc, "certificateB");
        return certificateB;
    }
    private Certificate CreateCertificateC(Microcontroller mc)
    {
        //Init TestSuite
        ITest testA = new ElectronicVersatilityTest(new[] { 3.3, 5 });
        ITest testB = new HasHardDiskTest();
        var suite = new TestSuite();
        suite.AddTest(testA);
        suite.AddTest(testB);

        var certificateC = new Certificate(suite, mc, "CertificateC");
        return certificateC;
    }
}