public static class BookStore
{
    public static decimal Total(IEnumerable<int> books)
    {
        int[] counts = new int[5];
        foreach (var book in books)
        {
            counts[book - 1]++;
        }

        double total = 0;

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

            double discount = setSize switch
            {
                5 => 0.25,
                4 => 0.20,
                3 => 0.10,
                2 => 0.05,
                _ => 0
            };
            double price = setSize * 8 * (1 - discount);
            total += price;

            for (int i = 0; i < setSize; i++)
            {
                counts[i]--;
            }

            Array.Sort(counts);
            Array.Reverse(counts);
        }

        return (int)total;
    }
}