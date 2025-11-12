public class Player
{
    public int RollDie()
    {
        return new Random().Next(18) + 1;
    }

    public double GenerateSpellStrength()
    {
        return new Random().NextDouble() * 100.0;
    }
}
