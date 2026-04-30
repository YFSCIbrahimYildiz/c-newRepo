public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        var sonuc = new List<(int, int)>();
        int satirSayisi = matrix.GetLength(0);
        int sutunSayisi = matrix.GetLength(1);

        for (int i = 0; i < satirSayisi; i++)
        {
            for (int j = 0; j < sutunSayisi; j++)
            {
                int firstDeger = matrix[i, j];
                bool big = true;
                bool small = true;

                for (int k = 0; k < sutunSayisi; k++)
                {
                    if (matrix[i, k] > firstDeger)
                    {
                        big = false;
                        break;
                    }
                }

                for (int k = 0; k < satirSayisi; k++)
                {
                    if (matrix[k, j] < firstDeger)
                    {
                        small = false;
                        break;
                    }
                }

                if (big && small)
                {
                    sonuc.Add((i + 1, j + 1));
                }
            }
        }

        return sonuc;
    }
}