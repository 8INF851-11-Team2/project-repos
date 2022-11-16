namespace LOCMI.Core.Certificates.Tests.TestCases;

using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;

/// <summary>
///     Test if the microcontroller respects the physical specifications
/// </summary>
/// <remarks>Test 2</remarks>
public sealed class PhysicalSpecificationTest : TestCase
{
    public PhysicalSpecificationTest()
        : base("Validation of physical specifications")
    {
    }

    public Dimension MaxDimension { get; init; } = new (double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue);

    public Dimension MinDimension { get; init; } = new (0, 0, 0, 0);

    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.Dimension == null)
        {
            return new[] { "The microcontroller hasn't dimension" };
        }

        Dimension dimension = microcontroller.Dimension.Value;

        var failureCauses = new List<string>();

        failureCauses.AddRange(TestMaxDimension(dimension));

        failureCauses.AddRange(TestMinDimension(dimension));

        return failureCauses;
    }

    private IEnumerable<string> TestMaxDimension(Dimension dimension)
    {
        if (dimension.Length > MaxDimension.Length)
        {
            yield return $"The length of the microcontroller ({dimension.Length}) is greater than the maximum length ({MaxDimension.Length})";
        }

        if (dimension.Width > MaxDimension.Width)
        {
            yield return $"The width of the microcontroller ({dimension.Width}) is greater than the maximum length ({MaxDimension.Width})";
        }

        if (dimension.Height > MaxDimension.Height)
        {
            yield return $"The height of the microcontroller ({dimension.Height}) is greater than the maximum length ({MaxDimension.Height})";
        }

        if (dimension.Weight > MaxDimension.Weight)
        {
            yield return $"The weight of the microcontroller ({dimension.Weight}) is greater than the maximum length ({MaxDimension.Weight})";
        }
    }

    private IEnumerable<string> TestMinDimension(Dimension dimension)
    {
        if (dimension.Length > MinDimension.Length)
        {
            yield return $"The length of the microcontroller ({dimension.Length}) is less than the maximum length ({MinDimension.Length})";
        }

        if (dimension.Width > MinDimension.Width)
        {
            yield return $"The width of the microcontroller ({dimension.Width}) is less than the maximum length ({MinDimension.Width})";
        }

        if (dimension.Height > MinDimension.Height)
        {
            yield return $"The height of the microcontroller ({dimension.Height}) is less than the maximum length ({MinDimension.Height})";
        }

        if (dimension.Weight > MinDimension.Weight)
        {
            yield return $"The weight of the microcontroller ({dimension.Weight}) is greater than the maximum length ({MinDimension.Weight})";
        }
    }
}