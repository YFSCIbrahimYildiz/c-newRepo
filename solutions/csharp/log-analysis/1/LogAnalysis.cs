public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    
    // TODO: define the 'Message()' extension method on the `string` type

    // TODO: define the 'LogLevel()' extension method on the `string` type



    public static string SubstringAfter(this string str,string delimeter){
        var log=str.Split(delimeter);
        return log[1];
    }
    public static string SubstringBetween(this string str, string start, string end){
        
        int start1=str.IndexOf(start)+start.Length;
        int end1=str.IndexOf(end);
        string sonuc=str.Substring(start1, end1-start1);
        return sonuc;
    }
    public static string Message(this string str){
        return SubstringAfter(str,": ");
    }
    public static string LogLevel(this string str){
        return SubstringBetween(str,"[","]");
    }
    
}