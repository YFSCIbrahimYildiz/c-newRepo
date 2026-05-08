public static class BafflingBirthdays
{
    public static DateOnly[] RandomBirthdates(int numberOfBirthdays)
    {
        DateOnly[] birthdays = new DateOnly[numberOfBirthdays];
        DateTime dateTimeFirst = new DateTime(2006, 1, 1);
        Random random = new Random();
        for (int i = 0; i < numberOfBirthdays; i++)
        {
            int tarih = random.Next(1, 365);
            DateTime newTarih = dateTimeFirst.AddDays(tarih);
            birthdays[i] = DateOnly.FromDateTime(newTarih);
        }

        return birthdays;
    }

    public static bool SharedBirthday(DateOnly[] birthdays)
    {
        string sorgu;
        string sorgu2;
        for (int i = 0; i < birthdays.Length; i++)
        {
            sorgu = birthdays[i].Day.ToString();
            sorgu += birthdays[i].Month.ToString();
            if (i < birthdays.Length - 1)
            {
                for (int j = 0; j < birthdays.Length; j++)
                {
                    sorgu2 = birthdays[j].Day.ToString();
                    sorgu2 = birthdays[j].Month.ToString();
                    if (sorgu == sorgu2)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    public static double EstimatedProbabilityOfSharedBirthday(int numberOfBirthdays)
    {
        int sayac = 0;
        bool varMi = false;
        DateOnly[] sonuc;
        for (int i = 0; i < numberOfBirthdays; i++)
        {
            sonuc = RandomBirthdates(numberOfBirthdays);
            varMi = SharedBirthday(sonuc);
            if (varMi)
            {
                sayac++;
            }
        }

        return sayac / (double)numberOfBirthdays;
    }
}