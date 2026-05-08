public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.Trim().EndsWith("?") && statement == statement.ToUpper())
        {
            return "Calm down, I know what I'm doing!";
        }
        if (statement.Trim().EndsWith("?"))
        {
            return "Sure.";
        }
        if (statement == statement.ToUpper())
        {
            return "Whoa, chill out!";
        }
        if (statement.Trim() == "")
        {
            return "Fine. Be that way!";
        }

        return "Whatever.";
    }
}