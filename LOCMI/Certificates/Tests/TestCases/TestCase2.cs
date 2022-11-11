namespace LOCMI.Certificates.Tests.TestCases;

using LOCMI.Core;
using LOCMI.Core.Utils;

public class TestCase2 : TestCase
{
    private readonly Dimension _maxDimension;

    private readonly Dimension _minDimension;

    public TestCase2(Dimension maxDimension, Dimension minDimension)
        : base("Validation of physical specifications")
    {
        _maxDimension = maxDimension;
        _minDimension = minDimension;
    }

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
        if (dimension.Length > _maxDimension.Length)
        {
            yield return $"The length of the microcontroller ({dimension.Length}) is greater than the maximum length ({_maxDimension.Length})";
        }

        if (dimension.Width > _maxDimension.Width)
        {
            yield return $"The width of the microcontroller ({dimension.Width}) is greater than the maximum length ({_maxDimension.Width})";
        }

        if (dimension.Height > _maxDimension.Height)
        {
            yield return $"The height of the microcontroller ({dimension.Height}) is greater than the maximum length ({_maxDimension.Height})";
        }

        if (dimension.Weight > _maxDimension.Weight)
        {
            yield return $"The weight of the microcontroller ({dimension.Weight}) is greater than the maximum length ({_maxDimension.Weight})";
        }
    }

    private IEnumerable<string> TestMinDimension(Dimension dimension)
    {
        if (dimension.Length > _minDimension.Length)
        {
            yield return $"The length of the microcontroller ({dimension.Length}) is less than the maximum length ({_minDimension.Length})";
        }

        if (dimension.Width > _minDimension.Width)
        {
            yield return $"The width of the microcontroller ({dimension.Width}) is less than the maximum length ({_minDimension.Width})";
        }

        if (dimension.Height > _minDimension.Height)
        {
            yield return $"The height of the microcontroller ({dimension.Height}) is less than the maximum length ({_minDimension.Height})";
        }

        if (dimension.Weight > _minDimension.Weight)
        {
            yield return $"The weight of the microcontroller ({dimension.Weight}) is greater than the maximum length ({_minDimension.Weight})";
        }
    }
}