public static class Bob
{
    public static string Response(string statement)
    {
        if (IsEmpty(statement))
        {
            return "Fine. Be that way!";
        }

        if (IsAllCaps(statement) && IsContainLetter(statement))
        {
            if (IsQuestion(statement))
            {
                return "Calm down, I know what I'm doing!";
            }
            else
            {
                return "Whoa, chill out!";
            }
        }
        else
        {
            if (IsQuestion(statement))
            {
                return "Sure.";
            }
        }
        
        
        return "Whatever.";
    }

    public static bool IsAllCaps(string statement)
    {
        for (int i = 0; i < statement.Length; i++)
        {
            if (Char.IsLower(statement[i]))
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsQuestion(string statement)
    {
        if (statement.Trim()[^1].Equals('?'))
        {
            return true;
        }

        return false;
    }

    public static bool IsEmpty(string statement)
    {
        if (String.IsNullOrWhiteSpace(statement))
        {
            return true;
        }

        return false;
    }

    public static bool IsContainLetter(string statement)
    {
        for (int i = 0; i < statement.Length; i++)
        {
            if (Char.IsLetter(statement[i]))
            {
                return true;
            }
        }

        return false;
    }
}