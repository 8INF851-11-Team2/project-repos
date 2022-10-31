using LOCMI.Test;

namespace LOCMI.Certificate.TestResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Certificate.TestCase;

public interface ITestResult
{
    public List<TestFailure> TestFailures { get; set; }
    public void AddFailure(TestCase t, string cause);
    public int GetFailureCount();
    public int GetRunCount();
    public bool IsSucceful();
    public void IncrementRunCounter();
}
