namespace LOCMI.Certificates.TestCases;

using LOCMI.Certificates.TestResult;
using LOCMI.Core;

public sealed class TestCaseA : TestCase
{
    public TestCaseA(string name)
        : base(name)
    {
    }

    public override void Run(ITestResult testResult, Microcontroller mc)
    {
        if (mc.Name is "MicrocontrollerA")
        {
            testResult.IncrementRunCounter();
        }
        else
        {
            testResult.AddFailure(this, $"Names are not similar : '{mc.Name}' and 'MicrocontrollerA'");
        }
    }
}