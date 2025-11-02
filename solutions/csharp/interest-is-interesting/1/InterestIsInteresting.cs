static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance < 0.0m ? 3.213f : balance >= 0.0m && balance < 1000.0m ? 0.5f 
            : balance >= 1000.0m && balance < 5000.0m ? 1.621f : balance >= 5000.0m ? 2.475f : 0.0f;
    }

    public static decimal Interest(decimal balance)
    {
        return (balance * (decimal)InterestRate(balance)) / 100.0m;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int numberOfYears = 0;
        while (balance < targetBalance) 
        {
            balance += Interest(balance);
            numberOfYears++;
        }

        return numberOfYears;
    }
}
