using System;
namespace LOCMI.Controllers
{
    public class PromptController
    {
        private View _view;

        public PromptController()
        {
            _view = new View();
        }

        public void run(string msgToPrint)
        {
            _view.display(msgToPrint);
        }
    }
}

