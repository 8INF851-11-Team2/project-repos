namespace LOCMI.Certificates;

using LOCMI.Certificates.TestResult;
using LOCMI.Core;

public sealed class TestSuite : ITest
{
    public TestSuite()
    {
        Tests = new List<ITest>();
    }

    public List<ITest> Tests { get; }

    public void AddTest(ITest test)
    {
        Tests.Add(test);
    }

    public void Run(ITestResult testResult, Microcontroller mc)
    {
        foreach (ITest test in Tests)
        {
            test.Run(testResult, mc);
        }
    }
}