using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> sums = new HashSet<int>();

        foreach (var deger in multiples)
        {
            for (int i = 1; (deger * i) < max; i++)
            {
                sums.Add(deger * i);
            }
        }

        return sums.Sum();
    }
}