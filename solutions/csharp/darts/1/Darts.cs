public static class Darts
{
    public static int Score(double x, double y)
    {
        double deger = Math.Sqrt((x * x) + (y * y));
        if (deger <= 1) return 10;
        else if (deger <= 5) return 5;
        else if (deger <= 10) return 1;
        return 0;
    }
}