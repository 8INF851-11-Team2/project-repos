namespace LOCMI.Controllers;

using LOCMI.Certificates;
using LOCMI.Certificates.Tests;
using LOCMI.Views;

public sealed class PromptController
{
    public static void Run(List<Certificate> certificates)
    {
        foreach (Certificate cert in certificates)
        {
            IView.Display("==============");
            ITestResult testResult = cert.TestResult;
            IView.Display(cert.Name + " for : " + cert.Microcontroller.Name + ", successful : " + cert.IsSuccess);
            IView.Display("Successful test(s) : ");

            foreach (TestCase tc in testResult.TestSuccessful)
            {
                IView.Display(tc.Name);
            }

            if (!cert.IsSuccess)
            {
                IView.Display("");
                IView.Display("Failed test(s) : ");

                foreach (TestFailure tf in testResult.TestFailures)
                {
                    var causes = "";
                    IEnumerable<string> strings = tf.Causes;
                    strings.ToList().ForEach(s => causes += s + "\n");
                    IView.Display(tf.TestCase.Name + ", cause(s) : \n" + causes);
                }
            }
        }
    }
}