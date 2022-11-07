namespace LOCMI.Certificates.TestCases;

using LOCMI.Certificates.TestResult;
using LOCMI.Core;

public abstract class TestCase : ITest
{
    protected TestCase(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public abstract void Run(ITestResult testResult, Microcontroller mc);
}