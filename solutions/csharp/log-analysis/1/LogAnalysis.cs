public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string input) 
    {
        return input[input.Length - 1].Equals(' ') ? str.Substring(str.LastIndexOf(input.Trim()[input.Trim().Length - 1]) + 1).Trim() : str.Substring(str.LastIndexOf(input[input.Length - 1]) + 1);
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstInput, string secondInput) 
    {
        return str.SubstringAfter(firstInput).Substring(0, str.SubstringAfter(firstInput).IndexOf(secondInput[0]));
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) 
    {
        return str.SubstringAfter(": ");
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) 
    {
        return str.SubstringBetween("[", "]");
    }
}