public static class BookStore
{
    public static decimal Total(IEnumerable<int> books)
    {
        int[] counts = new int[5];
        foreach (var book in books)
        {
            counts[book - 1]++;
        }

        decimal total = 0m;

        Array.Sort(counts);
        Array.Reverse(counts);

        while (counts[0] > 0)
        {
            int setSize = 0;

            for (int i = 0; i < 5; i++)
            {
                if (counts[i] > 0) setSize++;
            }

            if (setSize == 0) break;
            if (setSize == 5 && counts[4] >= 1 && counts[3] >= 1)
            {
                setSize = 4;
            }

            decimal discount = setSize switch
            {
                5 => 0.25m,
                4 => 0.20m,
                3 => 0.10m,
                2 => 0.05m,
                _ => 0m
            };
            decimal price = setSize * 8m * (1 - discount);
            total += price;

            for (int i = 0; i < setSize; i++)
            {
                counts[i]--;
            }

            Array.Sort(counts);
            Array.Reverse(counts);
        }

        return (decimal)total;
    }
}