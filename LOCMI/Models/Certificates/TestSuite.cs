namespace LOCMI.Models.Certificates;

using LOCMI.Core;

public class TestSuite : ITest
{
    public void AddTest(ITest test)
    {
    }

    public void Run(ITestResult testResult, Microcontroller microController)
    {
        throw new NotImplementedException();
    }
}