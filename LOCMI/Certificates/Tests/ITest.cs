namespace LOCMI.Certificates.Tests;

using LOCMI.Core;

public interface ITest
{
    public void Run(ITestResult testResult, Microcontroller mc);
}