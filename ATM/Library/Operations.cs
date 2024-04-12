using Library.Models;

namespace Library
{
    public class Operations
    {
        public static void Withdraw(Account account, decimal amount)
        {
            if (amount == 0)
                throw new ArgumentException("The minimum value that can be withdrawn is 10");

            else if (amount > account.Balance)
                throw new ArgumentException("The withdraw amount can't be greater than the account balance");

            account.Balance -= amount;
        }

        public static void Deposit(Account account, decimal amount)
        {
            account.Balance += amount;
        }
    }
}
