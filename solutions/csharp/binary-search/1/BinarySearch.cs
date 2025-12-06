public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        Array.Sort(input);

        int leftIndex = 0;
        int rightIndex = input.Length - 1;

        while (leftIndex <= rightIndex) 
        {
            int middleIndex = leftIndex + (rightIndex - leftIndex / 2);
            int middleValue = input[middleIndex];

            if (middleValue == value) 
            {
                return middleIndex;
            }
            else if (middleValue < value) 
            {
                leftIndex = middleIndex + 1;
            }
            else 
            {
                rightIndex = middleIndex - 1;
            }
        }

        return -1;
    }
}