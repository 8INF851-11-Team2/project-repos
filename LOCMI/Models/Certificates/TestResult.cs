namespace LOCMI.Models.Certificates;

public interface ITestResult
{
    public void AddFailure(ITest test, string cause);

    public void GetFailureCount();

    public void GetRunCount();

    public void IncrementRunCounter();

    public bool IsSuccessful();
}