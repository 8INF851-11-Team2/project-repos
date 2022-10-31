namespace LOCMI.Models.Certificates;

public class TestResultImpl : ITestResult
{
    public int FailureCounter;

    public int RunCounter;

    public void AddFailure(ITest test, string cause)
    {
        throw new NotImplementedException();
    }

    public void GetFailureCount()
    {
        throw new NotImplementedException();
    }

    public void GetRunCount()
    {
        throw new NotImplementedException();
    }

    public void IncrementRunCounter()
    {
        throw new NotImplementedException();
    }

    public bool IsSuccessful()
    {
        throw new NotImplementedException();
    }
}