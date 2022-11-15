namespace LOCMI.Controllers;

using LOCMI.Certificates;
using LOCMI.Certificates.Tests;
using LOCMI.Views;

public sealed class PromptController
{
    private readonly IView _view;

    public PromptController(IView view)
    {
        _view = view;
    }

    public void Run(List<Certificate> certificates)
    {
        foreach (Certificate cert in certificates)
        {
            _view.Display("==============");
            ITestResult testResult = cert.TestResult;
            _view.Display(cert.Name + " for : " + cert.Microcontroller.Name + ", successful : " + cert.IsSuccess);
            _view.Display("Successful test(s) : ");

            foreach (TestCase tc in testResult.TestSuccessful)
            {
                _view.Display(tc.Name);
            }

            if (!cert.IsSuccess)
            {
                _view.Display("");
                _view.Display("Failed test(s) : ");

                foreach (TestFailure tf in testResult.TestFailures)
                {
                    var causes = "";
                    IEnumerable<string> strings = tf.Causes;
                    strings.ToList().ForEach(s => causes += s + "\n");
                    _view.Display(tf.TestCase.Name + ", cause(s) : \n" + causes);
                }
            }
        }
    }
}