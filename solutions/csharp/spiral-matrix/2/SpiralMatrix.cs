public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        int deger = 1;
        int satirBas = 0, satirSon = size - 1;
        int sutunBas = 0, sutunSon = size - 1;
        while (deger <= size * size)
        {
            for (int i = sutunBas; i <= sutunSon && deger <= size * size; i++)
            {
                matrix[satirBas, i] = deger++;
            }

            satirBas++;

            for (int i = satirBas; i <= satirSon && deger <= size * size; i++)
            {
                matrix[i, sutunSon] = deger++;
            }

            sutunSon--;

            for (int i = sutunSon; i >= sutunBas && deger <= size * size; i--)
            {
                matrix[satirSon, i] = deger++;
            }

            satirSon--;

            for (int i = satirSon; i >= satirBas && deger <= size * size; i--)
            {
                matrix[i, sutunBas] = deger++;
            }

            sutunBas++;
        }

        return matrix;
    }
}