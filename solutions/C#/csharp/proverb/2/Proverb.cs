public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        string[] recites = new string[subjects.Length];
        if (subjects.Length > 0)
        {
            for (int i = 0; i < subjects.Length - 1; i++)
            {
                if (i < subjects.Length)
                {
                    recites[i] = $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.";
                }
            }


            recites[subjects.Length - 1] = $"And all for the want of a {subjects[0]}.";
            return recites;
        }
        else
        {
            return [];
        }
        
    }
}