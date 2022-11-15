namespace LOCMI.Certificates.Tests;

using LOCMI.Core;

public abstract class TestCase : ITest
{
    protected TestCase(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void Run(ITestResult testResult, Microcontroller mc)
    {
        IEnumerable<string> failureCauses = Test(mc).ToList();

        if (failureCauses.Any())
        {
            testResult.AddFailure(this, failureCauses);
        }
        else
        {
            testResult.IncrementRunCounter();
        }
    }

    protected abstract IEnumerable<string> Test(Microcontroller microcontroller);
}