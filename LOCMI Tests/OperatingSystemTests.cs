namespace LOCMI_Tests;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.Results;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;
using LOCMI.Microcontrollers;

[TestClass]
public class OperatingSystemTests
{
    [TestMethod]
    public void OperatingSystemTestWithMicrocontrollerA()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        TestCase testCase = new OperatingSystemTest(new OS());

        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsFalse(testResult.IsSuccessful());
    }

    [TestMethod]
    public void OperatingSystemTestWithMicrocontrollerB()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        TestCase testCase = new OperatingSystemTest(new OS());
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsTrue(testResult.IsSuccessful());
    }

    [TestMethod]
    public void OperatingSystemTestWithMicrocontrollerC()
    {
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        TestCase testCase = new OperatingSystemTest(new OS());
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsFalse(testResult.IsSuccessful());
    }
}