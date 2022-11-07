using LOCMI.Certificates;
using LOCMI.Certificates.TestCases;
using LOCMI.Certificates.TestResult;
using LOCMI.Core;
using LOCMI.Microcontrollers;

//Build Microcontroller
var builder = new MicrocontrollerABuilder();
Microcontroller mc = builder.GetResult();

//Init TestSuite
var suite = new TestSuite();
ITest testA = new TestCaseA("TestCaseA");
ITest testB = new TestCaseB("TestCaseB");
suite.AddTest(testA);
suite.AddTest(testB);

//Certificate generation
var certificate = new Certificate(suite, mc, "CertificateA");
certificate.Certify();
ITestResult impl = certificate.TestResult;

//Print
Console.WriteLine("Failure count : " + impl.GetFailureCount());
Console.WriteLine("Run count : " + impl.GetRunCount());
Console.WriteLine("Result : " + certificate.IsSuccess);

//Print Failure
ITestResult testResult = certificate.TestResult;
List<TestFailure> list = testResult.TestFailures;

foreach (TestFailure test in list)
{
    Console.WriteLine("Failure on test : " + test.TestCase.Name + ", reason : " + test.Cause);
}

Console.WriteLine("Press a Key to quit...");
Console.ReadKey();