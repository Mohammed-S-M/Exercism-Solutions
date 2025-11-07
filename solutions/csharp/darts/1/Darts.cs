public static class Darts
{
    public static int Score(double x, double y)
    {
        int score = 0;
        double distance = Math.Sqrt((x * x) + (y * y));

        if (distance <= 1) 
        {
            score = 10;
        }
        else if (distance <= 5) 
        {
            score = 5;
        }
        else if (distance <= 10)
        {
            score = 1;
        }

        return score;
    }
}
