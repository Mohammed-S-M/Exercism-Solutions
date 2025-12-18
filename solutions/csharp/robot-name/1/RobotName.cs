public class Robot
{
    private string _randomName;
    private static HashSet<string> _robotNameList = new HashSet<string>();
    
    public string Name
    {
        get
        {
            return _randomName;
        }
    }

    public Robot()
    {
        _randomName = GenerateUniqueNames();
    }

    public void Reset()
    {
        _randomName = "";
        _randomName = GenerateUniqueNames();
    }

    private static int GenerateRandomLetter()
    {
        return new Random().Next(65, 91);
    }

    private static int GenerateRandomDigit()
    {
        return new Random().Next(10);
    }

    private static string GenerateRandomName()
    {
        return $"{(char)GenerateRandomLetter()}{(char)GenerateRandomLetter()}" +
            $"{GenerateRandomDigit()}{GenerateRandomDigit()}{GenerateRandomDigit()}";
    }

    private static string GenerateUniqueNames()
    {
        string name;

        do
        {
            name = GenerateRandomName();
        }
        while (!_robotNameList.Add(name));

        return name;
    }
}