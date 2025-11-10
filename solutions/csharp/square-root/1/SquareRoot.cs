public static class SquareRoot
{
    public static int Root(int number)
    {
        int halfNumber = number != 1 ? number / 2 : halfNumber = 1;
        int sqrtNumber = 0;

        while (halfNumber > 0) 
        {
            if (halfNumber * halfNumber == number) 
            {
                sqrtNumber = halfNumber;
                break;
            }

            halfNumber--;
        }

        return sqrtNumber;
    }
}
