namespace LOCMI_Tests;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.Results;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;
using LOCMI.Microcontrollers;

[TestClass]
public class GeneralInformationTests
{
    [TestMethod]
    public void GeneralInformationTestWithMicrocontrollerA()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        //RP2000
        TestCase testCase = new GeneralInformationTest(new Identification("Raspberry PI", "RP2000"));
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsFalse(testResult.IsSuccessful());

        //RP4000
        testCase = new GeneralInformationTest(new Identification("Raspberry PI", "RP4000"));
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsTrue(testResult.IsSuccessful());

        //AR1240
        testCase = new GeneralInformationTest(new Identification("Arduino", "AR1240"));
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsFalse(testResult.IsSuccessful());
    }

    [TestMethod]
    public void GeneralInformationTestWithMicrocontrollerB()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        //RP2000
        TestCase testCase = new GeneralInformationTest(new Identification("Raspberry PI", "RP2000"));
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsTrue(testResult.IsSuccessful());

        //RP4000
        testCase = new GeneralInformationTest(new Identification("Raspberry PI", "RP4000"));
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsFalse(testResult.IsSuccessful());

        //AR1240
        testCase = new GeneralInformationTest(new Identification("Arduino", "AR1240"));
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsFalse(testResult.IsSuccessful());
    }

    [TestMethod]
    public void GeneralInformationTestWithMicrocontrollerC()
    {
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        //RP2000
        TestCase testCase = new GeneralInformationTest(new Identification("Raspberry PI", "RP2000"));
        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsFalse(testResult.IsSuccessful());

        //RP4000
        testCase = new GeneralInformationTest(new Identification("Raspberry PI", "RP4000"));
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsFalse(testResult.IsSuccessful());

        //AR1240
        testCase = new GeneralInformationTest(new Identification("Arduino", "AR1240"));
        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsTrue(testResult.IsSuccessful());
    }
}