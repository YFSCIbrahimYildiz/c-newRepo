public static class SquareRoot
{
    public static int Root(int number)
    {
        if (number<=1) return  number;
        int low = 1;
        int hight=number;

        while (low<=hight)
        {
            int mid =(low+hight)/2;
            int square = mid * mid;
            if (square == number) return (int)mid;
            if (square<number) low = mid + 1;
            else hight = mid - 1;
            
        }
        return hight;

    }
}
