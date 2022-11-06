namespace LOCMI.Models.Certificates;

using LOCMI.Core;
using static System.Net.Mime.MediaTypeNames;

public class TestSuite : ITest
{
    private List<ITest> _tests;

    public TestSuite()
    {
        _tests = new List<ITest>();
    }
    public void AddTest(ITest test)
    {
        _tests.Add(test);
    }

    public void Run(ITestResult testResult, Microcontroller microController)
    {
        foreach (ITest test in _tests)
        {
            test.Run(testResult, microController);
        }
    }
}