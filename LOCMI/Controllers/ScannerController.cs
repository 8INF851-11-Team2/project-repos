using System;
namespace LOCMI.Controllers
{
    public class ScannerController
    {
        private View _view;

        public ScannerController()
        {
            _view = new View();
        }

        public string run()
        {
            _view.display("Enter information");
            return Console.ReadLine();

        }
    }
}

