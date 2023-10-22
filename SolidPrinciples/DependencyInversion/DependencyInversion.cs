namespace SolidPrinciples.DependencyInversion;

// Without DIP
internal class LightBulb
{
    public void TurnOn()
    {
    }

    public void TurnOff()
    {
    }
}

internal class Switch
{
    private readonly LightBulb _bulb = new();

    public void Operate()
    {
        // some condition
        if (true)
        {
            _bulb.TurnOn();
        }
        else
        {
            _bulb.TurnOff();
        }
    }
}

// With DIP
internal interface ISwitchable
{
    void TurnOn();

    void TurnOff();
}

internal class LightBulbDip : ISwitchable
{
    public void TurnOn()
    {
    }

    public void TurnOff()
    {
    }
}

internal class SwitchDip
{
    private readonly ISwitchable _device;

    public SwitchDip(ISwitchable device)
    {
        _device = device;
    }

    public void Operate()
    {
        // some condition
        if (true)
        {
            _device.TurnOn();
        }
        else
        {
            _device.TurnOff();
        }
    }
}