namespace LOCMI.Controllers;

using LOCMI.Models.Menu.DemoMenu;
using LOCMI.Models.Menu;
using LOCMI.Views;
using LOCMI.Core;
using LOCMI.Microcontrollers;
using LOCMI.Certificates.Tests;
using LOCMI.Certificates.Tests.TestCases;
using LOCMI.Certificates;

public sealed class DemoController
{
    private Menu<IDemoMenuCommand> _menuDemo;

    private View _view;

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
        TestSuite suiteA = new TestSuite();
        suiteA.AddTest(testA);
        TestSuite suiteB = new TestSuite();
        suiteB.AddTest(testB);

        //Certificate
        Certificate certificatA = new Certificate(suiteA, microcontrollerA, "CertificatA");
        Certificate certificatB = new Certificate(suiteB, microcontrollerA, "CertificatB");
        List<Certificate> certificates = new List<Certificate>() { certificatA, certificatB };

        CertificateDemonstrationDTO certificateDemonstrationDTO = new CertificateDemonstrationDTO();

        _menuDemo = new Menu<IDemoMenuCommand>("Demonstration Menu");
        TestingAllCommand testingAllCommand = new TestingAllCommand(certificates, certificateDemonstrationDTO);
        TestingIndividualCommand testingIndividualCommand = new TestingIndividualCommand(certificatA, certificateDemonstrationDTO);
        _menuDemo.Add("Testing All", testingAllCommand);
        _menuDemo.Add("Testing Individual", testingIndividualCommand);

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