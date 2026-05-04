class RemoteControlCar
{
    private int _batery = 100;
    private int _meters = 0;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_meters} meters";
    }


    public string BatteryDisplay()
    {
        if (_batery > 0)
        {
            return $"Battery at {_batery}%";
        }

        return $"Battery empty";
    }


    public void Drive()
    {
        if (_batery > 0)
        {
            _meters += 20;
            _batery -= 1;
        }
    }
}