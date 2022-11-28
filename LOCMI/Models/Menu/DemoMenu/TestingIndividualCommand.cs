namespace LOCMI.Models.Menu.DemoMenu;

using LOCMI.Certificates;
using LOCMI.Controllers;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.DTO;
using LOCMI.Core.Microcontrollers;
using LOCMI.Microcontrollers;
using LOCMI.Views;

public sealed class TestingIndividualCommand : IDemoMenuCommand
{
    private readonly CertificateDemonstrationDTO _dto;

    private readonly PromptController _promptController;

    private readonly IView _view;

    public TestingIndividualCommand(IView view, CertificateDemonstrationDTO certify)
    {
        _promptController = new PromptController(view);
        _view = view;
        _dto = certify;
    }

    public void Execute()
    {
        _view.Display("\nChoose a choice from the menu below:");

        _view.Display("1 -------->  Microcontroller A");
        _view.Display("2 -------->  Microcontroller B");
        _view.Display("3 -------->  Microcontroller C");

        string? read = _view.GetUserEntry();
        var userChoice = 0;

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
                    _view.Display("Please enter a valid choice");
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

        var certificates = new List<Certificate>
        {
            new CertificateA(microcontroller),
            new CertificateB(microcontroller),
            new CertificateC(microcontroller),
        };

        _dto.Certificates = certificates;
        _dto.Apply();

        _promptController.Run(certificates);

        var p = new PrintCommand(_dto);
        p.Execute();
    }

    public bool IsExecutable()
    {
        throw new NotImplementedException();
    }
}