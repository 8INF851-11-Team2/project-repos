namespace LOCMI.Certificates.Tests;

using LOCMI.Core;

public abstract class TestCase : ITest
{
    protected TestCase(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract void Run(ITestResult testResult, Microcontroller mc);
}