namespace LOCMI.Certificates.Tests.TestCases;

using LOCMI.Core;
using LOCMI.Core.Utils;

public class TestCase5 : TestCase
{
    public TestCase5()
        : base("Languages")
    {
    }

    public IEnumerable<Language> MandatoryLanguages { get; init; } = new List<Language>();

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.Languages == null)
        {
            if (MandatoryLanguages.Any())
            {
                string mandatoryLanguages = string.Join(" / ", MandatoryLanguages.Select(static c => c.Name));
                yield return $"The microcontroller hasn't language but it must have these languages: {mandatoryLanguages}";
            }
        }
        else
        {
            IEnumerable<Language> missingLanguages = MandatoryLanguages.Where(c => !microcontroller.Languages.Contains(c));

            foreach (Language language in missingLanguages)
            {
                yield return $"The microcontroller must have the {language.Name} language with the {language.Version}";
            }
        }
    }
}