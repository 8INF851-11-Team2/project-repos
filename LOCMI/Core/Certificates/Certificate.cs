namespace LOCMI.Core.Certificates;

using System.Text.Json.Serialization;
using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.Results;
using LOCMI.Core.Microcontrollers;

public class Certificate
{
    [JsonConstructor]
    public Certificate(string name)
    {
        Name = name;
    }

    protected Certificate(string name, Microcontroller microcontroller)
    {
        Name = name;
        Microcontroller = microcontroller;
    }

    public bool IsSuccess { get; private set; }

    [JsonIgnore]
    public Microcontroller? Microcontroller { get; set; }

    public string Name { get; set; }

    public ITest Test { get; protected init; } = new TestSuite();

    [JsonIgnore]
    public ITestResult TestResult { get; } = new TestResult();

    public void Certify()
    {
        if (Microcontroller != null)
        {
            Test.Run(TestResult, Microcontroller);

            if (TestResult.IsSuccessful())
            {
                IsSuccess = true;
            }
        }
    }
}