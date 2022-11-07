﻿namespace LOCMI.Certificates;

using LOCMI.Certificates.Tests;
using LOCMI.Certificates.Tests.Results;
using LOCMI.Core;

public sealed class Certificate
{
    public Certificate(ITest test, Microcontroller mc, string name)
    {
        Name = name;
        Microcontroller = mc;
        Test = test;
        TestResult = new TestResult();
        Date = DateTime.Now;
    }

    public DateTime Date { get; set; }

    public bool IsSuccess { get; set; }

    public Microcontroller Microcontroller { get; set; }

    public string Name { get; set; }

    public ITest Test { get; set; }

    public ITestResult TestResult { get; set; }

    public void Certify()
    {
        Test.Run(TestResult, Microcontroller);

        if (TestResult.IsSuccessful())
        {
            IsSuccess = true;
        }
    }
}