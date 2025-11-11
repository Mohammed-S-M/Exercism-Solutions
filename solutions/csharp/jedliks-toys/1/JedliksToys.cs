class RemoteControlCar
{
    public int DistanceDriven = 0;
    public int BatteryLife = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {this.DistanceDriven} meters";
    }

    public string BatteryDisplay()
    {
       return this.BatteryLife > 0 ? $"Battery at {this.BatteryLife}%" : "Battery empty";
    }

    public void Drive()
    {
        if (this.BatteryLife == 0) 
        {
            Console.WriteLine("Battery empty");
            this.DistanceDriven += 0;
        }
        else 
        {
            this.DistanceDriven += 20;
            this.BatteryLife -= 1;
        }

    }
}
