namespace LOCMI.Models.Certificates;

using LOCMI.Core;

public interface ITest
{
    public void Run(ITestResult testResult, Microcontroller microController);
}