namespace LOCMI.Core.Utils;

using System.Collections;

public sealed class Ports : IEnumerable<EPortType>
{
    private readonly Dictionary<int, EPortType> _ports = new ();

    public int Count => _ports.Count;

    public EPortType? this[int numPin]
    {
        get => _ports.ContainsKey(numPin)
                   ? _ports[numPin]
                   : null;

        set
        {
            if (value != null)
            {
                _ports[numPin] = value.Value;
            }
            else
            {
                if (_ports.ContainsKey(numPin))
                {
                    _ports.Remove(numPin);
                }
            }
        }
    }

    public void Add(int numPin, EPortType portType)
    {
        _ports[numPin] = portType;
    }

    /// <inheritdoc />
    public IEnumerator<EPortType> GetEnumerator()
    {
        return _ports.Values.GetEnumerator();
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return _ports.GetEnumerator();
    }
}