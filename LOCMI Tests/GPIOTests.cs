namespace LOCMI_Tests;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.Results;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Microcontrollers;

[TestClass]
public class GPIOTests
{
    [TestMethod]
    public void GPIOTestWithMicrocontrollerA()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        TestCase testCase = new GPIOTest
        {
            MaxDataPort = 7,
            MinDataPort = 7,
            MaxGround = 3,
            MinGround = 2,
            MaxOtherPort = 8,
            MinOtherPort = 6,
            MaxPowerPort = 1,
            MinPowerPort = 1,
        };

        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsTrue(testResult.IsSuccessful());
    }

    [TestMethod]
    public void GPIOTestWithMicrocontrollerB()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        TestCase testCase = new GPIOTest
        {
            MaxDataPort = 7,
            MinDataPort = 7,
            MaxGround = 3,
            MinGround = 2,
            MaxOtherPort = 8,
            MinOtherPort = 6,
            MaxPowerPort = 1,
            MinPowerPort = 1,
        };

        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsFalse(testResult.IsSuccessful());
    }

    [TestMethod]
    public void GPIOTestWithMicrocontrollerC()
    {
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        TestCase testCase = new GPIOTest
        {
            MaxDataPort = 7,
            MinDataPort = 7,
            MaxGround = 3,
            MinGround = 2,
            MaxOtherPort = 8,
            MinOtherPort = 6,
            MaxPowerPort = 1,
            MinPowerPort = 1,
        };

        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsFalse(testResult.IsSuccessful());
    }
}