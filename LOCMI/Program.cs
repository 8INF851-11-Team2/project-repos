using LOCMI.Certificate.TestCase;
using LOCMI.Certificate.TestResult;
using LOCMI.Core;
using LOCMI.Microcontrollers;
using LOCMI.Test;

//Build Microcontroller
var builder = new MicrocontrollerABuilder();
Microcontroller mc = builder.GetResult();

//Init TestSuite
TestSuite suite = new TestSuite();
ITest testA = new TestCaseA("TestCaseA");
ITest testB = new TestCaseB("TestCaseB");
suite.AddTest(testA);
suite.AddTest(testB);

//Certificate generation
Certificate c = new Certificate(suite, mc, "CertificatA");
c.Certifier();
ITestResult impl = c.TestResult;

//Print
Console.WriteLine("Failure count : " + impl.GetFailureCount());
Console.WriteLine("Run count : " + impl.GetRunCount());
Console.WriteLine("Result certifier : " + c.IsSucces);

//Print Failure 
ITestResult testResult = c.TestResult;
List<TestFailure> list = testResult.TestFailures;
foreach(TestFailure test in list)
{
    Console.WriteLine("Failure on test : " + test.TestCase.Name + ", reason : " + test.Cause);
}

Console.WriteLine("Press a Key to quit...");
Console.ReadKey();