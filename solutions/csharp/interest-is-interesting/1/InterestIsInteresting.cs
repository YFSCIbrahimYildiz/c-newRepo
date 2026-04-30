static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) return 3.213f;
        if (0 <= balance && balance < 1000) return 0.5f;
        if (1000 <= balance && balance < 5000) return 1.621f;
        return 2.475f;
    }

    public static decimal Interest(decimal balance)
    {
        decimal interestRate = (decimal)InterestRate(balance) / 100m;
        return balance * interestRate;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int year = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            year++;
        }

        return year;
    }
}