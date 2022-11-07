namespace LOCMI.Certificates;

using LOCMI.Certificates.TestResult;
using LOCMI.Core;

public interface ITest
{
    public void Run(ITestResult testResult, Microcontroller mc);
}