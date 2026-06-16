namespace ConsoleApp1
{
    // Holds the money for every currency in one place.
    // The balances array is private, so other classes can only change it
    // through Deposit / Withdraw. This is encapsulation: the rules live
    // next to the data they protect.
    public class Wallet
    {
        // One slot per currency, indexed by the Currency enum (PLN = 0, EUR = 1, ...).
        private readonly decimal[] balances = new decimal[Enum.GetValues<Currency>().Length];

        public decimal GetBalance(Currency currency)
        {
            return balances[(int)currency];
        }

        // Adds money. Returns false for zero/negative amounts instead of trusting the caller.
        public bool Deposit(Currency currency, decimal amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            balances[(int)currency] += amount;
            return true;
        }

        // Removes money only if there is enough. Returns false otherwise,
        // so the balance can never go negative.
        public bool Withdraw(Currency currency, decimal amount)
        {
            if (amount <= 0 || amount > balances[(int)currency])
            {
                return false;
            }

            balances[(int)currency] -= amount;
            return true;
        }
    }
}
