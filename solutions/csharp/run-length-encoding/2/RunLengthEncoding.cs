using System.Linq;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        string deger = "";
        List<string> inputList = new List<string>();
        int sayi = 1;
        if (input.Length > 0)
        {
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

            if (sayi > 1)
            {
                inputList.Add(sayi + input[input.Length - 1].ToString());
            }
            else
            {
                inputList.Add(input[input.Length - 1].ToString());
            }
        }


        return string.Concat(inputList.ToArray());
    }

    public static string Decode(string input)
    {
        int sayi = 0;
        string str = "";
        List<string> inputList = new List<string>();

        if (input.Length > 0)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    while (i < input.Length && char.IsDigit(input[i]))
                    {
                        str += input[i];
                        i++;
                    }

                    sayi = int.Parse(str);
                    str = "";

                    for (int j = 0; j < sayi; j++)
                    {
                        inputList.Add(input[i].ToString());
                    }
                }
                else
                {
                    inputList.Add(input[i].ToString());
                }
            }
        }


        return string.Concat(inputList.ToArray());
    }
}