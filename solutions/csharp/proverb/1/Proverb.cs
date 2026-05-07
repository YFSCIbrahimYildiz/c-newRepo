public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        string[] recites = new string[subjects.Length+1];
        for (int i = 0; i < subjects.Length - 1; i++)
        {
            if (i < subjects.Length)
            {
                recites[i] = $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.";
            }
        }

        recites[subjects.Length -1] =
            $"For want of a {subjects[subjects.Length - 2]} the {subjects[subjects.Length - 1]} was lost.";

        recites[subjects.Length] = $"And all for the want of a {subjects[0]}.";

        return recites;
    }
}