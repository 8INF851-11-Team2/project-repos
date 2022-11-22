using LOCMI.Controllers;
using LOCMI.Views;

IView view = new ConsoleView();

var initialController = new InitialController(view);
initialController.Run();