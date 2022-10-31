using LOCMI.Certificate.TestCase;
using LOCMI.Certificate.TestResult;
using LOCMI.Core;
using LOCMI.Microcontrollers;
using LOCMI.Test;

Console.WriteLine("Hello, World!");

var builder = new MicrocontrollerABuilder();
Microcontroller mc = builder.GetResult();

TestSuite suite = new TestSuite();
ITest testA = new TestCaseA("TestCaseA");
ITest testB = new TestCaseB("TestCaseB");
suite.AddTest(testA);
suite.AddTest(testB);

Certificate c = new Certificate(suite, mc, "CertificatA");
c.Certifier();
ITestResult impl = c.TestResult;

Console.WriteLine("Failure compt : " + impl.GetFailureCount());
Console.WriteLine("Run compt : " + impl.GetRunCount());
Console.WriteLine("Result certifier : " + c.IsSucces);

ITestResult testResult = c.TestResult;
List<TestFailure> list = testResult.TestFailures;
foreach(TestFailure test in list)
{
    Console.WriteLine("Failure on test : " + test.TestCase.Name + ", reason : " + test.Cause);
}