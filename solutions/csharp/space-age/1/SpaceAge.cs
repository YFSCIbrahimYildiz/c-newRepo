public class SpaceAge
{
    private int _second;
    private double _earth = 31557600;

    public SpaceAge(int seconds)
    {
        _second = seconds;
    }

    public double OnEarth()
    {
        return _second / _earth;
    }

    public double OnMercury()
    {
        return _second / (_earth * 0.2408467);
    }

    public double OnVenus()
    {
        return _second / (_earth * 0.61519726);
    }

    public double OnMars()
    {
        return _second / (_earth * 1.8808158);
    }

    public double OnJupiter()
    {
        return _second / (_earth * 11.862615);
    }

    public double OnSaturn()
    {
        return _second / (_earth * 29.447498);
    }

    public double OnUranus()
    {
        return _second / (_earth * 84.016846);
    }

    public double OnNeptune()
    {
        return _second / (_earth * 164.79132);
    }
}