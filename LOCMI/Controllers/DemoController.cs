namespace LOCMI.Controllers;

using LOCMI.Certificates;
using LOCMI.Certificates.Tests;
using LOCMI.Certificates.Tests.TestCases;
using LOCMI.Core;
using LOCMI.Microcontrollers;
using LOCMI.Models.Menu;
using LOCMI.Models.Menu.DemoMenu;
using LOCMI.Views;

public sealed class DemoController : MenuController<IDemoMenuCommand>
{
    public DemoController(View view)
        : base(view)
    {
    }

    /// <inheritdoc />
    protected override Menu<IDemoMenuCommand> SetMenu()
    {
        var builder = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builder.GetResult();

        //Init TestSuite
        ITest testA = new TestCase1();
        var suiteA = new TestSuite();
        suiteA.AddTest(testA);

        var suiteB = new TestSuite();

        //Certificate
        var certificateA = new Certificate(suiteA, microcontrollerA, "CertificateA");
        var certificateB = new Certificate(suiteB, microcontrollerA, "CertificateB");

        var certificates = new List<Certificate>
        {
            certificateA,
            certificateB,
        };

        var certificateDemonstrationDTO = new CertificateDemonstrationDTO();

        var testingAllCommand = new TestingAllCommand(certificates, certificateDemonstrationDTO);
        var testingIndividualCommand = new TestingIndividualCommand(certificateA, certificateDemonstrationDTO);

        return new Menu<IDemoMenuCommand>("Demonstration Menu")
        {
            { "Testing All", testingAllCommand },
            { "Testing Individual", testingIndividualCommand },
        };
    }
}