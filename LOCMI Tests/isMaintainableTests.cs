namespace LOCMI_Tests;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.Results;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Microcontrollers;

[TestClass]
public class IsMaintainableTests
{
    [TestMethod]
    public void IsMaintainableTestWithMicrocontrollerA()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        TestCase testCase = new IsMaintainableTest();

        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsFalse(testResult.IsSuccessful());
    }

    [TestMethod]
    public void IsMaintainableTestWithMicrocontrollerB()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        TestCase testCase = new IsMaintainableTest();
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsTrue(testResult.IsSuccessful());
    }

    [TestMethod]
    public void IsMaintainableTestWithMicrocontrollerC()
    {
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        TestCase testCase = new IsMaintainableTest();
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsFalse(testResult.IsSuccessful());
    }
}