class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int _speed;
    private int _batteryDrain;
    private int _battery = 100;
    private int _meters = 0;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return _batteryDrain > _battery;
    }

    public int DistanceDriven()
    {
        return _meters;
    }

    public void Drive()
    {
        if (_battery < _batteryDrain) return;
        _meters += _speed;
        _battery -= _batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}


class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }
    // TODO: define the constructor for the 'RaceTrack' class

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }

        return car.DistanceDriven() >= _distance;
    }
}