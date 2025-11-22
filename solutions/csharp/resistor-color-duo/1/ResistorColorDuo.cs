public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string result = "";

        for (int i = 0; i < 2; i++) 
        {
            result += ColorCode(colors[i]);
        }

        return int.Parse(result);
    }

    public static string[] Colors() 
    {
        return new string[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    }

    public static int ColorCode(string color)
    {
        return Array.IndexOf(Colors(), color);
    }
}
