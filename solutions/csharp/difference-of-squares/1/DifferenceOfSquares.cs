public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int toplam = 0;
        for (int i = 1; i <= max; i++)
        {
            toplam += i;
        }

        return toplam;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int toplam = 0;
        for (int i = 1; i <= max; i++)
        {
            toplam += i * i;
        }

        return toplam;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        int sonuc= CalculateSquareOfSum(max) - CalculateDifferenceOfSquares(max);
        return sonuc;
    }
}