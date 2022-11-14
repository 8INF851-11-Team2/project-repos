namespace LOCMI.Certificates.Tests.TestCases;

using LOCMI.Core;

public sealed class TestCaseB : TestCase
{
    public TestCaseB(string name)
        : base(name)
    {
    }

    public override void Run(ITestResult testResult, Microcontroller mc)
    {
        if (mc.Name is "MicrocontrollerB")
        {
            testResult.AddSuccess(this);
        }
        else
        {
            testResult.AddFailure(this, $"Names are not similar : '{mc.Name}' and 'MicrocontrollerB'");
        }
    }
}