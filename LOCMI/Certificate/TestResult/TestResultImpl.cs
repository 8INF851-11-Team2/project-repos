using LOCMI.Test;

namespace LOCMI.Certificate.TestResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Certificate.TestCase;

public class TestResultImpl : ITestResult
{
    public int FailureCounter { get; set; }
    public int RunCounter { get; set; }
    public List<TestFailure> TestFailures { get; set; }

    public TestResultImpl()
    {
        FailureCounter = 0;
        RunCounter = 0;
        TestFailures = new List<TestFailure>();
    }

    public void AddFailure(TestCase t, string cause)
    {
        FailureCounter++;
        TestFailures.Add(new TestFailure(cause, t));
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

    public bool IsSucceful()
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
