using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder builder = new StringBuilder();
        bool isAfterDash = false;
        foreach (var c in identifier)
        {
            if (c == ' ')
            {
                builder.Append('_');
            }

            else if (char.IsControl(c))
            {
                builder.Append("CTRL");
            }

            else if (c == '-')
            {
                isAfterDash = true;
            }

            else if (char.IsLetter(c))
            {
                if (c >= 'α' && c <= 'ω')
                {
                }
                else if (isAfterDash)
                {
                    builder.Append(char.ToUpper(c));
                    isAfterDash = false;
                }
                else
                {
                    builder.Append(c);
                }
            }
        }

        return builder.ToString();
    }
}