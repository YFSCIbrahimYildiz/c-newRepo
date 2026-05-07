public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int deger = Array.IndexOf(Colors(), color.ToLower());

        return deger;
    }

    public static string[] Colors()
    {
        string[] renkler = new[]
            { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return renkler;
    }
}