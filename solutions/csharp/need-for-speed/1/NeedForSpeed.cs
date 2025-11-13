class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int _distanceDriven;
    private int _batteryLife;
    private int _carSpeed;
    private int _batteryDrain;

    public RemoteControlCar(int carSpeed, int batteryDrain) 
    {
        _carSpeed = carSpeed;
        _batteryDrain = batteryDrain;
        _batteryLife = 100;
    }
    
    public bool BatteryDrained()
    {
        return _batteryLife == 0 || _batteryLife - _batteryDrain < 0;
    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if (_batteryLife <= 0 || _batteryLife - _batteryDrain < 0) 
        {
            _batteryLife = 0;
        }
        else 
        {
            _batteryLife -= _batteryDrain;
            _distanceDriven += _carSpeed;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    public int _distance;

    public RaceTrack(int distance) 
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() < _distance) 
        {
            if (car.BatteryDrained()) 
            {
                return false;
            }
            car.Drive();
        }

        return true;
    }
}
