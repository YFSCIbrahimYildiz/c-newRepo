public static class Languages
{
    public static List<string> NewList()
    {
        List<string> newList = new List<string>();
        return newList;
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> languahesList = new List<string>();
        languahesList.Add("C#");
        languahesList.Add("Clojure");
        languahesList.Add("Elm");
        return languahesList;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        if (languages.Contains(language))
        {
            return true;
        }

        return false;
    }

    public static List<string> ReverseList(List<string> languages)
    {
        List<string> newList = new List<string>();
        if (languages.Count > 0)
        {
            for (int i = languages.Count - 1; i >= 0; i--)
            {
                newList.Add(languages[i]);
            }
        }

        return newList;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count > 0)
        {
            if (languages[0] == "C#")
            {
                return true;
            }

            if (languages.Count > 1)
            {
                if (languages[1] == "C#" && 2 <= languages.Count && languages.Count <= 3)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        return languages.Count == new HashSet<string>(languages).Count;
    }
}