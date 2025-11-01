public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        int firstHashIndex = phoneNumber.IndexOf("-");
        int lastHashIndex = phoneNumber.LastIndexOf("-");

        string areaCode = phoneNumber.Substring(0, firstHashIndex);
        string prefixCode = phoneNumber.Substring(firstHashIndex + 1, 
                                                  lastHashIndex - firstHashIndex - 1);
        string lastFourDigits = phoneNumber.Substring(lastHashIndex + 1);

        return (areaCode == "212", prefixCode == "555", lastFourDigits);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
