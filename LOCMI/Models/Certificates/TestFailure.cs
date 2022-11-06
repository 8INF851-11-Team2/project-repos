namespace LOCMI.Models.Certificates;

public class TestFailure
{
    public string Cause;

    public ITest TestCase;

    public TestFailure(string result, ITest testCase)
    {
        TestCase = testCase;
        Cause = result;
    }
}