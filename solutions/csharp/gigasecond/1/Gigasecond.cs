public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        var date = moment.AddSeconds(1_000_000_000);
        return date;
    }
}