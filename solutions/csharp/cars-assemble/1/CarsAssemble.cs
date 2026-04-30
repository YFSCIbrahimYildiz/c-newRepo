static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (0 == speed) return 0.00;
        if (1 <= speed && speed <= 4) return 1;
        if (5 <= speed && speed <= 8) return 0.90;
        if (9 == speed) return 0.80;
        return 0.77;
    }

    public static double ProductionRatePerHour(int speed)
    {
        double productionRate = SuccessRate(speed);
        return (speed * 221) * productionRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double workingItemsPer = ProductionRatePerHour(speed);
        return (int)(workingItemsPer / 60);
    }
}