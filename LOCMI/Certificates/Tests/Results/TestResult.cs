namespace LOCMI.Certificates.Tests.Results;

public sealed class TestResult : ITestResult
{
    public TestResult()
    {
        FailureCounter = 0;
        RunCounter = 0;
        TestFailures = new List<TestFailure>();
        TestSuccessful = new List<TestCase>();
    }

    public int FailureCounter { get; set; }

    public int RunCounter { get; set; }

    public List<TestFailure> TestFailures { get; set; }

    public List<TestCase> TestSuccessful { get; set; }

    public void AddFailure(TestCase testCase, IEnumerable<string> causes)
    {
        FailureCounter++;
        TestFailures.Add(new TestFailure(causes, testCase));
    }

    public void AddSuccess(TestCase testCase)
    {
        TestSuccessful.Add(testCase);
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