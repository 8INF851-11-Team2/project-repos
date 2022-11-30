namespace LOCMI.Core.Certificates.Tests;

using LOCMI.Core.Microcontrollers;

public sealed class TestSuite : ITest
{
    public List<ITest> Tests { get; set; } = new ();

    public void Add(ITest test)
    {
        Tests.Add(test);
    }

    public IEnumerator<ITest> GetEnumerator()
    {
        return Tests.GetEnumerator();
    }

    public void Run(ITestResult testResult, Microcontroller mc)
    {
        foreach (ITest test in Tests)
        {
            test.Run(testResult, mc);
        }
    }
}