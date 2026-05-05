public class Player
{
    public int RollDie()
    {
        Random rnd = new Random();
        int deger = rnd.Next(1, 19);
        return deger;
    }

    public double GenerateSpellStrength()
    {
        Random rnd = new Random();
        double deger = rnd.NextDouble() * 100;
        return deger;
    }
}