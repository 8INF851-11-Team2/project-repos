namespace LOCMI.Core.Microcontrollers.Utils;

using System.Collections;
using LOCMI.Core.Microcontrollers.Utils.PortTypes;

public sealed class Ports : IEnumerable<Port>
{
    private readonly Dictionary<int, Port> _ports = new ();

    public int Count => _ports.Count;

    public Port? this[int numPin]
    {
        get => _ports.ContainsKey(numPin)
                   ? _ports[numPin]
                   : null;

        set
        {
            if (value != null)
            {
                _ports[numPin] = value;
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

    public void Add(int numPin, Port portType)
    {
        _ports[numPin] = portType;
    }

    /// <inheritdoc />
    public IEnumerator<Port> GetEnumerator()
    {
        return _ports.Values.GetEnumerator();
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return _ports.GetEnumerator();
    }
}