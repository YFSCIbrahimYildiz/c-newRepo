public static class BookStore
{
    public static decimal Total(IEnumerable<int> books)
    {
        
        int[] counts = new int[5];
        foreach (var book in books)
            counts[book - 1]++;
        
        decimal total = 0m;
        int fivesCount = 0;
        int threesCount = 0;
        
        Array.Sort(counts);
        Array.Reverse(counts);
        
        while (counts[0] > 0)
        {
            int setSize = counts.Count(c => c > 0);
            
            decimal discount = setSize switch
            {
                5 => 0.25m,
                4 => 0.20m,
                3 => 0.10m,
                2 => 0.05m,
                _ => 0m
            };
            
            total += setSize * 8m * (1 - discount);
            
            if (setSize == 5) fivesCount++;
            if (setSize == 3) threesCount++;
            
            for (int i = 0; i < setSize; i++)
                counts[i]--;
            
            Array.Sort(counts);
            Array.Reverse(counts);
        }
        
        int pairs = Math.Min(fivesCount, threesCount);
        total -= pairs * 0.4m;
        
        return total;
    }
}