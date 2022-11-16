namespace LOCMI.Core.Certificates.Tests;

using System.Collections;
using LOCMI.Core.Microcontrollers;

public sealed class TestSuite : ITest, IEnumerable<ITest>
{
    public TestSuite()
    {
        Tests = new List<ITest>();
    }

    public List<ITest> Tests { get; }

    public void Add(ITest test)
    {
        Tests.Add(test);
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}