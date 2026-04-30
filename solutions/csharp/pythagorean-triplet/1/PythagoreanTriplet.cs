public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        
        for (int i = 1; i < sum; i++)
        {
            int b_numarator = sum * sum - 2 * sum * i;
            int b_denominator = 2 * sum - 2 * i;

            if (b_numarator%b_denominator==0)
            {
                int b=b_numarator/b_denominator;
                int c = sum - i - b;
                if (i<b&&b<c)
                {
                    yield return (i,b,c);
                }
            }
        }
        
    }
    
}