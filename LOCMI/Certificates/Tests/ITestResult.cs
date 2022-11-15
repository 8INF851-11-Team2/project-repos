namespace LOCMI.Certificates.Tests;

public interface ITestResult
{
    public List<TestFailure> TestFailures { get; set; }

    public List<TestCase> TestSuccessful { get; set; }

    public void AddFailure(TestCase testCase, IEnumerable<string> causes);

    public void AddSuccess(TestCase testCase);

    public int GetFailureCount();

    public int GetRunCount();

    public void IncrementRunCounter();

    public bool IsSuccessful();
}