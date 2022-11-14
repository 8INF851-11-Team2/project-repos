namespace LOCMI.Controllers;

using LOCMI.Certificates;
using LOCMI.Views;

public class PromptController
{

    public static void Run(List<Certificate> certificates)
    {
        foreach(var cert in certificates)
        {
            IView.Display(cert.Microcontroller.Name + " : " + cert.Name + " : " + cert.IsSuccess);
        }
    }
}