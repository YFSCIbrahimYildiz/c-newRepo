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
       for (int i = 0; i < birthdays.Length; i++)
        {
            if (i < birthdays.Length - 1)
            {
                for (int j = i + 1; j < birthdays.Length; j++)
                {
                    if (birthdays[j].Day.ToString() == birthdays[i].Day.ToString() &&
                        birthdays[i].Month.ToString() == birthdays[j].Month.ToString())
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
        
            for (int i = 0; i < 10000; i++)
            {
                sonuc = RandomBirthdates(numberOfBirthdays);
                varMi = SharedBirthday(sonuc);
                if (varMi)
                {
                    sayac++;
                }
            }
        

        return sayac / (double)10000.0*100;
    }
}