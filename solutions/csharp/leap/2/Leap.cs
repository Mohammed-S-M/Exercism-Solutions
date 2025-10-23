public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        // using if else statements
        /*if (year % 4 == 0) 
        {
            if (year % 100 == 0) 
            {
                if (year % 400 == 0) 
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            else 
            {
                return true;
            }
        }

        return false;*/

        // using logical operator
        return (year % 4 == 0 && year % 100 != 0) || (year % 4 == 0 && year % 100 == 0 && year % 400 == 0);
    }
}