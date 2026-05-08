using System.Linq;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        string deger = "";
        List<string> inputList = new List<string>();
        int sayi = 1;
        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 1)
            {
                if (input[i] == input[i + 1])
                {
                    sayi++;
                }
                else
                {
                    if (sayi > 1)
                    {
                        inputList.Add(sayi + input[i].ToString());
                        sayi = 1;
                    }
                    else
                    {
                        inputList.Add(input[i].ToString());
                    }
                }
            }
        }

        return string.Concat(inputList.ToArray());
    }

    public static string Decode(string input)
    {
        int sayi = 0;
        List<string> inputList = new List<string>();

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                sayi = int.Parse(input[i].ToString());
                for (int j = 0; j < sayi; j++)
                {
                    inputList.Add(input[i+1].ToString());
                }

                i++;
            }
            else
            {
                inputList.Add(input[i].ToString());
            }
        }

        return string.Concat(inputList.ToArray());
    }
}