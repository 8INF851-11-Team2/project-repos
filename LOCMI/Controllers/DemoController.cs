namespace LOCMI.Controllers;

using LOCMI.Certificates;
using LOCMI.Certificates.Tests;
using LOCMI.Certificates.Tests.TestCases;
using LOCMI.Core;
using LOCMI.Microcontrollers;
using LOCMI.Models.Menu;
using LOCMI.Models.Menu.DemoMenu;
using LOCMI.Views;

public sealed class DemoController
{
    private readonly View _view;

    private Menu<IDemoMenuCommand> _menuDemo;

    public DemoController(View view)
    {
        _view = view;
    }

    public void Run()
    {
        var builder = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builder.GetResult();

        //Init TestSuite
        ITest testA = new TestCaseA("TestCaseA");
        ITest testB = new TestCaseB("TestCaseB");
        var suiteA = new TestSuite();
        suiteA.AddTest(testA);
        var suiteB = new TestSuite();
        suiteB.AddTest(testB);

        //Certificate
        var certificateA = new Certificate(suiteA, microcontrollerA, "CertificateA");
        var certificateB = new Certificate(suiteB, microcontrollerA, "CertificateB");
        var certificates = new List<Certificate> { certificateA, certificateB };

        var certificateDemonstrationDTO = new CertificateDemonstrationDTO();

        var testingAllCommand = new TestingAllCommand(certificates, certificateDemonstrationDTO);
        var testingIndividualCommand = new TestingIndividualCommand(certificateA, certificateDemonstrationDTO);

        _menuDemo = new Menu<IDemoMenuCommand>("Demonstration Menu")
        {
            { "Testing All", testingAllCommand }, { "Testing Individual", testingIndividualCommand },
        };

        while (!_menuDemo.GetIsClosed())
        {
            List<Entry<IDemoMenuCommand>> entries = _menuDemo.GetEntries();
            _view.Display("\nChoose a choice from the menu below:");
            /* display entries */
            entries.ForEach(static entry => entry.Show());
            /* Read the user's choice */
            string? read = Console.ReadLine();
            var userChoice = Convert.ToInt32(read);
            /* Execute the user's choice */
            _menuDemo.Execute(userChoice - 1);
        }
    }
}