public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> programmingList = NewList();
        programmingList.Add("C#");
        programmingList.Add("Clojure");
        programmingList.Add("Elm");
        
        return programmingList;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        List<string> programmingList = GetExistingLanguages();
        programmingList.Add(language);
        
        return programmingList;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count();
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        List<string> newList = new List<string>();

        for (int i = languages.Count() - 1; i >= 0; i--) 
        {
            newList.Add(languages[i]);
        }

        return newList;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count() == 0) 
        {
            return false;
        }
        
        if (languages[0] == "C#") 
        {
            return true;
        }
        else if (languages[1] == "C#" && (languages.Count() == 2 || languages.Count() == 3)) 
        {
            return true;
        }
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        List<string> uniqueList = new List<string>();

        foreach (string item in languages) 
        {
            if (!uniqueList.Contains(item)) 
            {
                uniqueList.Add(item);
            }
        }

        return uniqueList.Count() == languages.Count();
    }
}
