namespace LOCMI_Tests;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.Results;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Microcontrollers;

[TestClass]
public class ConnectorSpecificationTests
{
    [TestMethod]
    public void ConnectorSpecificationTestWithMicrocontrollerA()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        TestCase testCase = new ConnectorSpecificationTest("HDMI", "USB", "Wifi");
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsTrue(testResult.IsSuccessful());
    }

    [TestMethod]
    public void ConnectorSpecificationTestWithMicrocontrollerB()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        TestCase testCase = new ConnectorSpecificationTest("HDMI", "USB", "Wifi");
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsTrue(testResult.IsSuccessful());
    }

    [TestMethod]
    public void ConnectorSpecificationTestWithMicrocontrollerC()
    {
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        TestCase testCase = new ConnectorSpecificationTest("HDMI", "USB", "Wifi");
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsFalse(testResult.IsSuccessful());
    }
}