﻿namespace LOCMI.Certificates.Tests.TestCases;

using LOCMI.Core;

/// <summary>
///     Check if the microcontroller has a hard disk
/// </summary>
/// <remarks>Test 7</remarks>
public class HasHardDiskTest : TestCase
{
    public HasHardDiskTest()
        : base("Has hard disk")
    {
    }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        return microcontroller.Disk != null
                   ? Array.Empty<string>()
                   : new[] { "The microcontroller hasn't hard disk" };
    }
}