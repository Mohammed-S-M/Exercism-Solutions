static class AssemblyLine
{
    private const int speedPerHour = 221;
    public static double SuccessRate(int speed)
    {
        double rate;
        if (speed == 0) 
        {
            return rate = 0;
        }
        else if (speed >= 1 && speed <= 4) 
        {
            return rate = 1;
        }
        else if (speed >=5 && speed <= 8) 
        {
            return rate = 0.9;
        }
        else if (speed == 9) 
        {
            return rate = 0.8;
        }
        else if (speed == 10)  
        {
            return rate = 0.77;
        }

        return 0.0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * speedPerHour * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
