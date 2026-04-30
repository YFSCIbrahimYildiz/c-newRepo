public static class LineUp
{
    public static string Format(string name, int number)
    {
        string suffix = "th";


        var sayi = number % 100;


        if (number % 10 == 1 && sayi != 11)
            return $"{name}, you are the {number}st customer we serve today. Thank you!";


        if (number % 10 == 2 && sayi != 12)
            return $"{name}, you are the {number}nd customer we serve today. Thank you!";


        if (number % 10 == 3 && sayi != 13)
            return $"{name}, you are the {number}rd customer we serve today. Thank you!";


        else return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }
}