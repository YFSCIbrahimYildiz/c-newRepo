public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int toplam = 0;
        int sonuc=0;
        for (int i = 1; i <= max; i++)
        {
            toplam += i;
        }
        sonuc=toplam*toplam;

        return sonuc;
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
        int sonuc= CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
        return sonuc;
    }
}