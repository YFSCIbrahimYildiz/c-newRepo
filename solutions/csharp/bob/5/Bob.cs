using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        bool hepsiBuyuk = statement.All(c => !char.IsLower(c) && statement.Any(c => char.IsLetter(c)));
        if (statement.Trim().EndsWith("?") && hepsiBuyuk)
        {
            return "Calm down, I know what I'm doing!";
        }

        if (statement.Trim().EndsWith("?"))
        {
            return "Sure.";
        }
if (statement.Trim() == "")
        {
            return "Fine. Be that way!";
        }
        if (hepsiBuyuk)
        {
            return "Whoa, chill out!";
        }

        

        return "Whatever.";
    } 
}