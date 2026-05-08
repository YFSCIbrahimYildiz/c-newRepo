public static class ReverseString
{
    public static string Reverse(string input)
    {
        string newInput = "";
        if (input != null)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                newInput += input[i];
            }
        }

        return newInput;
    }
}