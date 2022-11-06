namespace LOCMI.Models.Certificates;

public class TestResultImpl : ITestResult
{
    public int FailureCounter;

    public int RunCounter;

    public List<TestFailure> TestFailures { get; set; }

    public TestResultImpl()
    {
        FailureCounter = 0;
        RunCounter = 0;
        TestFailures = new List<TestFailure>();
    }

    public void AddFailure(ITest test, string cause)
    {
        FailureCounter++;
        TestFailures.Add(new TestFailure(cause, test));
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
        if (TestFailures.Count() == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}