namespace LOCMI.Certificates;

using LOCMI.Certificates.TestCases;

public sealed class TestFailure
{
    public TestFailure(string r, TestCase tc)
    {
        Cause = r;
        TestCase = tc;
    }

    public string Cause { get; set; }

    public TestCase TestCase { get; set; }
}