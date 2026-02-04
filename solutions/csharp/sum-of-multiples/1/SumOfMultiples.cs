using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return multiples.Where(number => number < max).Select(number1 => Enumerable
                    .Range(number1, max - number1)
                    .Where(number2 => number1 != 0 && number2 % number1 == 0))
                    .SelectMany(number => number)
                    .Distinct()
                    .Sum();
    }
}