public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string newString = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                newString += ((char)('A' + ((text[i] - 'A' + shiftKey) % 26))).ToString();
            }

            if (char.IsLower(text[i]))
            {
                newString += ((char)('a' + ((text[i] - 'a' + shiftKey) % 26))).ToString();
            }
        }

        return newString;
    }
}