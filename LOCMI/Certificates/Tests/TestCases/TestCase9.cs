// -----------------------------------------------------------------------
//  <copyright project="LOCMI" file="TestCase9.cs" company="syuko">
//  Copyright (c) syuko. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LOCMI.Certificates.Tests.TestCases;

using LOCMI.Core;

public class TestCase9 : TestCase
{
    public TestCase9()
        : base("Maintenance testing")
    {
    }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (!microcontroller.IsMaintainable)
        {
            yield return "The microcontroller isn't maintainable";
        }
    }
}