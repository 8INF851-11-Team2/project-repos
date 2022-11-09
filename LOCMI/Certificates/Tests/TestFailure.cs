namespace LOCMI.Certificates.Tests;

public sealed class TestFailure
{
    public TestFailure(IEnumerable<string> causes, TestCase testCase)
    {
        Causes = causes;
        TestCase = testCase;
    }

    public IEnumerable<string> Causes { get; set; }

    public TestCase TestCase { get; set; }
}