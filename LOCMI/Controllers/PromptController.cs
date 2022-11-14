namespace LOCMI.Controllers;

using LOCMI.Certificates;
using LOCMI.Certificates.Tests;
using LOCMI.Views;

public class PromptController
{

    public static void Run(List<Certificate> certificates)
    {
        foreach(var cert in certificates)
        {
            IView.Display("==============");
            ITestResult testResult = cert.TestResult;
            IView.Display(cert.Name + " for : " + cert.Microcontroller.Name + " is successful : " + cert.IsSuccess);
            IView.Display("Successful test(s) : ");
            foreach(TestCase tc in testResult.TestSuccessful)
            {
                IView.Display(tc.Name);
            }
            IView.Display("");
            IView.Display("Failed test(s) : ");
            foreach (TestFailure tf in testResult.TestFailures)
            {
                IView.Display(tf.TestCase.Name + ", cause : " + tf.Cause);
            }
        }
    }
}