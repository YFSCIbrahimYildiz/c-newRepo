static class LogLine
{
    public static string Message(string logLine)
    {
        string[] parts=logLine.Split(":");
        return parts[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start=logLine.IndexOf('[')+1;
        int end=logLine.IndexOf(']');
        string result=logLine.Substring(start,end-start);
        return result.ToLower();
    }

    public static string Reformat(string logLine)
    {  string[] parts=logLine.Split(":");
       return $"{Message(logLine)} ({LogLevel(logLine)})";
           
    }
}
