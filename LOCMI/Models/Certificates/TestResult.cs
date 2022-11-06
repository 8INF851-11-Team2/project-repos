namespace LOCMI.Models.Certificates;

public interface ITestResult
{
    public List<TestFailure> TestFailures { get; set; }
    public void AddFailure(ITest test, string cause);

    public int GetFailureCount();

    public int GetRunCount();

    public void IncrementRunCounter();

    public bool IsSuccessful();
}