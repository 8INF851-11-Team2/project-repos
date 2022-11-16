namespace LOCMI.Core.Certificates.Tests.TestCases;

using System.Collections;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;

/// <summary>
///     Test if the microcontroller supports the asked programming languages
/// </summary>
/// <remarks>Test 5</remarks>
public sealed class ProgrammingLanguageTest : TestCase, IEnumerable<Language>
{
    private readonly List<Language> _mandatoryLanguages = new ();

    public ProgrammingLanguageTest()
        : base("Languages")
    {
    }

    public void Add(Language language)
    {
        _mandatoryLanguages.Add(language);
    }

    /// <inheritdoc />
    public IEnumerator<Language> GetEnumerator()
    {
        return _mandatoryLanguages.GetEnumerator();
    }

    /// <inheritdoc />
    protected override IEnumerable<string> Test(Microcontroller microcontroller)
    {
        if (microcontroller.Languages == null)
        {
            if (_mandatoryLanguages.Any())
            {
                string mandatoryLanguages = string.Join(" / ", _mandatoryLanguages.Select(static c => c.Name));
                yield return $"The microcontroller hasn't language but it must have these languages: {mandatoryLanguages}";
            }
        }
        else
        {
            IEnumerable<Language> missingLanguages = _mandatoryLanguages.Where(c => !microcontroller.Languages.Contains(c));

            foreach (Language language in missingLanguages)
            {
                yield return $"The microcontroller must have the {language.Name} language with the {language.Version}";
            }
        }
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}