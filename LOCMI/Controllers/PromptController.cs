namespace LOCMI.Controllers;

using System.Drawing;
using LOCMI.Core.Certificates;
using LOCMI.Core.Certificates.Tests;
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
            _view.Display("======================================================================");
            ITestResult testResult = cert.TestResult;

            _view.Display($"{cert.Name} for {cert.Microcontroller.Name}, successful: {cert.IsSuccess}", Color.White, cert.IsSuccess
                                                                                                                         ? Color.Green
                                                                                                                         : Color.Red);

            if (testResult.TestSuccessful.Any())
            {
                _view.Display(string.Empty);
                _view.Display("Successful test(s):");

                foreach (TestCase tc in testResult.TestSuccessful)
                {
                    _view.Display($"    {tc.Name}", Color.Green);
                }
            }

            if (testResult.TestFailures.Any())
            {
                _view.Display(string.Empty);
                _view.Display("Failed test(s):");

                foreach (TestFailure tf in testResult.TestFailures)
                {
                    _view.Display($"    {tf.TestCase.Name}, cause(s) :");
                    tf.Causes.ToList().ForEach(c => _view.Display($"        {c}", Color.Red));
                }
            }
        }
    }
}