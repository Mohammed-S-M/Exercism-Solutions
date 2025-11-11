public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int result = 0;
        int currentNumber = 0;

        while (currentNumber <= max)
        {
            result += currentNumber;
            currentNumber++;
        }

        return result * result;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int result = 0;
        int currentNumber = 0;

        while (currentNumber <= max)
        {
            result += (currentNumber * currentNumber);
            currentNumber++;
        }
        return result;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}