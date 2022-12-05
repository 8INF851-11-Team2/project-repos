namespace LOCMI_Tests;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.Results;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Microcontrollers;

[TestClass]
public class ElectronicVersatilityTests
{
    [TestMethod]
    public void ElectronicVersatilityTestWithMicrocontrollerA()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        //3.3 et 5
        TestCase testCase = new ElectronicVersatilityTest(3.3, 5);
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsFalse(testResult.IsSuccessful());

        //3.3
        testCase = new ElectronicVersatilityTest(3.3);
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsTrue(testResult.IsSuccessful());

        //5
        testCase = new ElectronicVersatilityTest(5);
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsFalse(testResult.IsSuccessful());
    }

    [TestMethod]
    public void ElectronicVersatilityTestWithMicrocontrollerB()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        //3.3 et 5
        TestCase testCase = new ElectronicVersatilityTest(3.3, 5);
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsTrue(testResult.IsSuccessful());

        //3.3
        testCase = new ElectronicVersatilityTest(3.3);
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsTrue(testResult.IsSuccessful());

        //5
        testCase = new ElectronicVersatilityTest(5);
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsTrue(testResult.IsSuccessful());
    }

    [TestMethod]
    public void ElectronicVersatilityTestWithMicrocontrollerC()
    {
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        //3.3 et 5
        TestCase testCase = new ElectronicVersatilityTest(3.3, 5);
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsTrue(testResult.IsSuccessful());

        //3.3
        testCase = new ElectronicVersatilityTest(3.3);
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsTrue(testResult.IsSuccessful());

        //5
        testCase = new ElectronicVersatilityTest(5);
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsTrue(testResult.IsSuccessful());
    }
}