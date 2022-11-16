namespace LOCMI.Controllers;

using LOCMI.Certificates;
using LOCMI.Certificates.Tests;
using LOCMI.Certificates.Tests.TestCases;
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

    private static Certificate CreateCertificateA(Microcontroller mc)
    {
        //Init TestSuite
        ITest testA = new ElectronicVersatilityTest(new[] { 3.3, 5 });
        var suiteA = new TestSuite();
        suiteA.AddTest(testA);

        var certificateA = new Certificate(suiteA, mc, "CertificateA");
        return certificateA;
    }

    private static Certificate CreateCertificateB(Microcontroller mc)
    {
        //Init TestSuite
        ITest testA = new HasHardDiskTest();
        var suiteA = new TestSuite();
        suiteA.AddTest(testA);

        var certificateB = new Certificate(suiteA, mc, "certificateB");
        return certificateB;
    }

    private static Certificate CreateCertificateC(Microcontroller mc)
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

    private static List<Certificate> CreateListCertificates()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        //Certificate
        Certificate certificateA1 = CreateCertificateA(microcontrollerA);
        Certificate certificateA2 = CreateCertificateA(microcontrollerB);
        Certificate certificateA3 = CreateCertificateA(microcontrollerC);
        Certificate certificateB1 = CreateCertificateB(microcontrollerA);
        Certificate certificateB2 = CreateCertificateB(microcontrollerB);
        Certificate certificateB3 = CreateCertificateB(microcontrollerC);
        Certificate certificateC1 = CreateCertificateC(microcontrollerA);
        Certificate certificateC2 = CreateCertificateC(microcontrollerB);
        Certificate certificateC3 = CreateCertificateC(microcontrollerC);

        var certificates = new List<Certificate>
        {
            certificateA1,
            certificateA2,
            certificateA3,
            certificateB1,
            certificateB2,
            certificateB3,
            certificateC1,
            certificateC2,
            certificateC3,
        };

        return certificates;
    }
}