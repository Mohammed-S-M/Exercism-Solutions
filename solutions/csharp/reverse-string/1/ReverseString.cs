public static class ReverseString
{
    public static string Reverse(string input)
    {
        string reversedInput = "";
        for (int i = input.Length - 1; i >= 0; i--) 
        {
            reversedInput += input[i];
        }

        return reversedInput;
    }
}