public static class LineUp
{
    public static string Format(string name, int number)
    {
        return $"{name}, you are the {number}{GetNumberEnding(number)} customer we serve today. Thank you!";
    }

    static string GetNumberEnding(int number)
    {
        
        string numberString = number + "";
        

        if (number >= 10) 
        {
            string lastTwoCharacters = numberString.Substring(numberString.Length - 2);
            if (lastTwoCharacters == "11" || lastTwoCharacters == "12" 
                || lastTwoCharacters == "13")
            {
                return "th";
            }
        }
        

        char lastCharacter = numberString[numberString.Length - 1];

        switch (lastCharacter)
        {
            case '1':
                return "st";
            case '2':
                return "nd";
            case '3':
                return "rd";
            default:
                return "th";
        }
    }
}
