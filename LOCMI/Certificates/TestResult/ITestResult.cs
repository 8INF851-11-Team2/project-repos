namespace LOCMI.Certificates.TestResult;

using LOCMI.Certificates.TestCases;

public interface ITestResult
{
    public List<TestFailure> TestFailures { get; set; }

    public void AddFailure(TestCase testCase, string cause);

    public int GetFailureCount();

    public int GetRunCount();

    public void IncrementRunCounter();

    public bool IsSuccessful();
}