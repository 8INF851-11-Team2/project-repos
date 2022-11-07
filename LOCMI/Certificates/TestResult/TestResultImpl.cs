namespace LOCMI.Certificates.TestResult;

using LOCMI.Certificates.TestCases;

public sealed class TestResultImpl : ITestResult
{
    public TestResultImpl()
    {
        FailureCounter = 0;
        RunCounter = 0;
        TestFailures = new List<TestFailure>();
    }

    public int FailureCounter { get; set; }

    public int RunCounter { get; set; }

    public List<TestFailure> TestFailures { get; set; }

    public void AddFailure(TestCase testCase, string cause)
    {
        FailureCounter++;
        TestFailures.Add(new TestFailure(cause, testCase));
    }

    public int GetFailureCount()
    {
        return FailureCounter;
    }

    public int GetRunCount()
    {
        return RunCounter;
    }

    public void IncrementRunCounter()
    {
        RunCounter++;
    }

    public bool IsSuccessful()
    {
        return !TestFailures.Any();
    }
}