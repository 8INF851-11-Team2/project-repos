namespace LOCMI_Tests;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.Results;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;
using LOCMI.Microcontrollers;

[TestClass]
public class PhysicalSpecificationTests
{
    [TestMethod]
    public void PhysicalSpecificationTestWithMicrocontrollerA()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        //certificate A
        TestCase testCase = new PhysicalSpecificationTest
        {
            MaxDimension = new Dimension(5, 2.10, 0.9, 100),
            MinDimension = new Dimension(4.5, 2.05, 0.5, 90),
        };

        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsTrue(testResult.IsSuccessful());

        //microcontroller B
        testCase = new PhysicalSpecificationTest
        {
            MaxDimension = new Dimension(6, 3, 0.8, 200),
            MinDimension = new Dimension(5, 2, 0.7, 100),
        };

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsFalse(testResult.IsSuccessful());

        //microcontroller C
        testCase = new PhysicalSpecificationTest
        {
            MaxDimension = new Dimension(2, 4, 0.7, 90),
            MinDimension = new Dimension(1, 3, 0.6, 80),
        };

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsFalse(testResult.IsSuccessful());
    }

    [TestMethod]
    public void PhysicalSpecificationTestWithMicrocontrollerB()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        //certificate A
        TestCase testCase = new PhysicalSpecificationTest
        {
            MaxDimension = new Dimension(5, 2.10, 0.9, 100),
            MinDimension = new Dimension(4.5, 2.05, 0.5, 90),
        };

        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsFalse(testResult.IsSuccessful());

        //microcontroller B
        testCase = new PhysicalSpecificationTest
        {
            MaxDimension = new Dimension(6, 3, 0.8, 200),
            MinDimension = new Dimension(5, 2, 0.7, 100),
        };

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsTrue(testResult.IsSuccessful());

        //microcontroller C
        testCase = new PhysicalSpecificationTest
        {
            MaxDimension = new Dimension(2, 4, 0.7, 90),
            MinDimension = new Dimension(1, 3, 0.6, 80),
        };

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsFalse(testResult.IsSuccessful());
    }

    [TestMethod]
    public void PhysicalSpecificationTestWithMicrocontrollerC()
    {
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        //certificate A
        TestCase testCase = new PhysicalSpecificationTest
        {
            MaxDimension = new Dimension(5, 2.10, 0.9, 100),
            MinDimension = new Dimension(4.5, 2.05, 0.5, 90),
        };

        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsFalse(testResult.IsSuccessful());

        //microcontroller B
        testCase = new PhysicalSpecificationTest
        {
            MaxDimension = new Dimension(6, 3, 0.8, 200),
            MinDimension = new Dimension(5, 2, 0.7, 100),
        };

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsFalse(testResult.IsSuccessful());

        //microcontroller C
        testCase = new PhysicalSpecificationTest
        {
            MaxDimension = new Dimension(2, 4, 0.7, 90),
            MinDimension = new Dimension(1, 3, 0.6, 80),
        };

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsTrue(testResult.IsSuccessful());
    }
}