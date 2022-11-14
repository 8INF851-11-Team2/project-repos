namespace LOCMI.Models.Menu.DemoMenu;

using LOCMI.Certificates;
using LOCMI.Certificates.Tests.TestCases;
using LOCMI.Certificates.Tests;
using LOCMI.Core;
using LOCMI.Microcontrollers;
using LOCMI.Views;
using LOCMI.Controllers;

public sealed class TestingIndividualCommand : IDemoMenuCommand
{
    private List<Certificate> _certificates;

    private readonly CertificateDemonstrationDTO _dto;

    public TestingIndividualCommand(CertificateDemonstrationDTO certify)
    {
        _certificates = new List<Certificate>();
        _dto = certify;
    }

    public void Execute()
    {
        IView.Display("\nChoose a choice from the menu below:");

        IView.Display("1 -------->  Microcontroller A");
        IView.Display("2 -------->  Microcontroller B");
        IView.Display("3 -------->  Microcontroller C");

        string? read = IView.GetUserEntry();
        int userChoice = 0;

        if (!string.IsNullOrEmpty(read))
        {
            try
            {
                userChoice = int.Parse(read);
            }
            catch (Exception e)
            {
                if (e is FormatException)
                {
                    IView.Display("Please enter a valid choice");
                }
                else
                {
                    throw;
                }
            }
        }

        Microcontroller microcontroller;
        switch (userChoice)
        {
            case 1:
                var builderA = new MicrocontrollerABuilder();
                microcontroller = builderA.GetResult();
                break;
            case 2:
                var builderB = new MicrocontrollerBBuilder();
                microcontroller = builderB.GetResult();
                break;
            case 3:
                var builderC = new MicrocontrollerCBuilder();
                microcontroller = builderC.GetResult();
                break;
            default:
                return;
        }

        _certificates = CreateListCertificates(microcontroller);
        _dto.SetCertificates(_certificates);
        _dto.Apply();
        PromptController.Run(_certificates);
        var p = new PrintCommand(_dto);
        p.Execute();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }

    private List<Certificate> CreateListCertificates(Microcontroller mc)
    {

        //Certificate
        var certificateA = CreateCertificateA(mc);
        var certificateB = CreateCertificateB(mc);
        var certificateC = CreateCertificateC(mc);

        var certificates = new List<Certificate>
        {
            certificateA,
            certificateB,
            certificateC
        };

        return certificates;
    }

    private Certificate CreateCertificateA(Microcontroller mc)
    {
        //Init TestSuite
        ITest test1 = new TestCaseA("TestCaseA");
        var suite = new TestSuite();
        suite.AddTest(test1);

        var certificateA = new Certificate(suite, mc, "CertificateA");
        return certificateA;
    }
    private Certificate CreateCertificateB(Microcontroller mc)
    {
        //Init TestSuite
        ITest test2 = new TestCaseB("TestCaseB");
        var suite = new TestSuite();
        suite.AddTest(test2);

        var certificateB = new Certificate(suite, mc, "certificateB");
        return certificateB;
    }
    private Certificate CreateCertificateC(Microcontroller mc)
    {
        //Init TestSuite
        ITest test1 = new TestCaseA("TestCaseA");
        ITest test2 = new TestCaseB("TestCaseB");
        var suite = new TestSuite();
        suite.AddTest(test1);
        suite.AddTest(test2);

        var certificateC = new Certificate(suite, mc, "CertificateC");
        return certificateC;
    }
}