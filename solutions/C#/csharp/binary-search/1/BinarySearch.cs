public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int ortaDeger;
        int yuksekDeger = input.Length - 1;
        int dusukDeger = 0;


        while (dusukDeger <= yuksekDeger)
        {
            ortaDeger = dusukDeger + (yuksekDeger - dusukDeger)/2;
            if (input[ortaDeger] == value)
            {
                return ortaDeger;
            }

            if (input[ortaDeger] > value)
            {
                yuksekDeger = ortaDeger - 1;
            }

            if (input[ortaDeger] < value)
            {
                dusukDeger = ortaDeger + 1;
            }
        }

        return -1;
    }
}