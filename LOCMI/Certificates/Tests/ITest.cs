namespace LOCMI.Certificates.Tests;

using LOCMI.Core.Microcontrollers;

public interface ITest
{
    public void Run(ITestResult testResult, Microcontroller mc);
}