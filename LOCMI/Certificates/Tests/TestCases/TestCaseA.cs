namespace LOCMI.Certificates.Tests.TestCases;

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
            testResult.AddSuccess(this);
        }
        else
        {
            testResult.AddFailure(this, $"Names are not similar : '{mc.Name}' and 'MicrocontrollerA'");
        }
    }
}