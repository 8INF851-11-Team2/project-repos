using System;
using LOCMI.Models.Menu;
namespace LOCMI.Controllers
{
    public class InitialController
    {
        private View? _view;
        private Menu<MainMenuCommand>? _mainMenu;

        public void run()
        {
            _view = new View();
            DemoController demoController = new DemoController(_view);
            ExperimentalController expController = new ExperimentalController(_view);
            MenuDemoCommand demoCommand = new MenuDemoCommand(demoController);
            MenuExpCommand expCommand = new MenuExpCommand(expController);
            _mainMenu = new Menu<MainMenuCommand>("Main Menu");
            _mainMenu.Add("Demonstration", demoCommand);
            _mainMenu.Add("Experimental", expCommand);

            while(!_mainMenu.getIsClosed())
            {
                List<IEntry<MainMenuCommand>> entries = _mainMenu.GetEntries();
                _view.display("Choose a choice from the menu below:");
                /* display entries */
                entries.ForEach(entry => entry.show());
                /* Read the user's choice */
                string read = Console.ReadLine();
                int userChoice = Convert.ToInt32(read);
                /* Execute the user's choice */
                _mainMenu.Execute(userChoice);
          
            }

        }
    }
}