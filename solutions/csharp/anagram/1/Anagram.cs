public class Anagram
{
    private string _baseWord;

    public Anagram(string baseWord)
    {
        _baseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> dogru = new List<string>();
        string baseWord2 = new string(_baseWord.OrderBy(c => c).ToArray()).ToLower();
        string potentialMatches2 = "";


        for (int i = 0; i < potentialMatches.Length; i++)
        {
            potentialMatches2 = string.Concat(potentialMatches[i].OrderBy(c => c).ToArray()).ToLower();
            if (baseWord2 == potentialMatches2)
            {
                dogru.Add(potentialMatches[i]);
            }
        }


        return dogru.ToArray();
    }
}