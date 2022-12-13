namespace LOCMI_Tests;

using LOCMI.Core.Certificates.Tests;
using LOCMI.Core.Certificates.Tests.Results;
using LOCMI.Core.Certificates.Tests.TestCases;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;
using LOCMI.Microcontrollers;

[TestClass]
public class ProgrammingLanguageTests
{
    [TestMethod]
    public void ProgrammingLanguageTestWithMicrocontrollerA()
    {
        var builderA = new MicrocontrollerABuilder();
        Microcontroller microcontrollerA = builderA.GetResult();

        //c++ 17
        TestCase testCase = new ProgrammingLanguageTest(new Language("C++", "17"));

        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsFalse(testResult.IsSuccessful());

        //c++
        testCase = new ProgrammingLanguageTest(new Language("C++", string.Empty));

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsFalse(testResult.IsSuccessful());

        //python 3.11.0
        testCase = new ProgrammingLanguageTest(new Language("python", "3.11.0"));

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerA);
        Assert.IsTrue(testResult.IsSuccessful());
    }

    [TestMethod]
    public void ProgrammingLanguageTestWithMicrocontrollerB()
    {
        var builderB = new MicrocontrollerBBuilder();
        Microcontroller microcontrollerB = builderB.GetResult();

        //c++ 17
        TestCase testCase = new ProgrammingLanguageTest(new Language("C++", "17"));

        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsTrue(testResult.IsSuccessful());

        //c++
        testCase = new ProgrammingLanguageTest(new Language("C++", string.Empty));

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsFalse(testResult.IsSuccessful());

        //python 3.11.0
        testCase = new ProgrammingLanguageTest(new Language("python", "3.11.0"));

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerB);
        Assert.IsFalse(testResult.IsSuccessful());
    }

    [TestMethod]
    public void ProgrammingLanguageTestWithMicrocontrollerC()
    {
        var builderC = new MicrocontrollerCBuilder();
        Microcontroller microcontrollerC = builderC.GetResult();

        //c++ 17
        TestCase testCase = new ProgrammingLanguageTest(new Language("C++", "17"));

        ITestResult testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsFalse(testResult.IsSuccessful());

        //c++
        testCase = new ProgrammingLanguageTest(new Language("C++", string.Empty));

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsTrue(testResult.IsSuccessful());

        //python 3.11.0
        testCase = new ProgrammingLanguageTest(new Language("python", "3.11.0"));

        testResult = new TestResult();
        testCase.Run(testResult, microcontrollerC);
        Assert.IsFalse(testResult.IsSuccessful());
    }
}