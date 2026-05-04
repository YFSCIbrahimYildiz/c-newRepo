class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] dizi = new int[7];
        dizi[0] = 0;
        dizi[1] = 2;
        dizi[2] = 5;
        dizi[3] = 3;
        dizi[4] = 7;
        dizi[5] = 8;
        dizi[6] = 4;
        return dizi;
    } 

    public int Today()
    {
        var dizi = birdsPerDay;
        return dizi[dizi.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        var dizi = birdsPerDay;
        dizi[dizi.Length - 1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        var dizi = birdsPerDay;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (0 == dizi[i])
            {
                return true;
            }
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var dizi = birdsPerDay;
        var toplam = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            toplam += birdsPerDay[i];
        }

        return toplam;
    }

    public int BusyDays()
    {
        var dizi = birdsPerDay;
        int i = 0;
        for (int j = 0; j < dizi.Length; j++)
        {
            if (5 <= dizi[j])
            {
                i++;
            }
        }

        return i;
    }
}