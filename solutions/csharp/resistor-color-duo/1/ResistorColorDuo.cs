public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string color = "";
        for (int i = 0; i < 2; i++)
        {
            color += Index(colors[i]);
        }

        return int.Parse(color);
    }

    public static string Index(string colors)
    {
        string[] renkler = new[]
            { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "gri", "white" };
        string color = Array.IndexOf(renkler, colors).ToString();
        return color;
    }
}