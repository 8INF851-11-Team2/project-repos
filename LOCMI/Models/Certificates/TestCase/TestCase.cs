namespace LOCMI.Models.Certificates.TestCase;

using LOCMI.Core;

public abstract class TestCase : ITest
{
    private string _name;

    public TestCase(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract void Run(ITestResult tr, Microcontroller mc);
}
