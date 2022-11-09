namespace LOCMI.Certificates.Tests.TestCases;

using LOCMI.Core;

public class TestCase7 : TestCase
{
    public TestCase7()
        : base("Has hard disk")
    {
    }

    /// <inheritdoc />
    public override void Run(ITestResult testResult, Microcontroller mc)
    {
        if (mc.Disk != null)
        {
            testResult.IncrementRunCounter();
        }
        else
        {
            testResult.AddFailure(this, new[] { "The microcontroller hasn't hard disk" });
        }
    }
}