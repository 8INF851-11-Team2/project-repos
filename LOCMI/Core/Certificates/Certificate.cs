namespace LOCMI.Core.Certificates;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.Results;
using LOCMI.Core.Microcontrollers;

public class Certificate
{
    public Certificate(ITest test, Microcontroller microcontroller, string name)
    {
        Name = name;
        Microcontroller = microcontroller;
        Test = test;
    }

    protected Certificate(string name, Microcontroller microcontroller)
    {
        Name = name;
        Microcontroller = microcontroller;
    }

    public bool IsSuccess { get; private set; }

    public Microcontroller Microcontroller { get; }

    public string Name { get; }

    public ITest Test { get; protected init; } = new TestSuite();

    public ITestResult TestResult { get; } = new TestResult();

    public void Certify()
    {
        Test.Run(TestResult, Microcontroller);

        if (TestResult.IsSuccessful())
        {
            IsSuccess = true;
        }
    }
}