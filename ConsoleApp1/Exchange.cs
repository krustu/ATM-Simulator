namespace ConsoleApp1
{
    // The three money operations. Each one talks to the Wallet through its
    // public methods, so it never touches the balances directly.
    public static class Exchange
    {
        private const decimal TopUpKeepRate = 0.98m; // 2% tax is kept by the bank.

        public static void TopUp(Wallet wallet, Currency currency)
        {
            while (true)
            {
                decimal input = InputHelper.GetAmount($"How much {currency} do you want to add? (0 to exit)");
                if (input == 0)
                {
                    Console.WriteLine("Exiting top-up process.");
                    break;
                }

                decimal added = input * TopUpKeepRate;
                if (!wallet.Deposit(currency, added))
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    continue;
                }

                Console.WriteLine("Tax 2% applied.");
                Console.WriteLine($"Added: {added} {currency}. Current balance: {wallet.GetBalance(currency)} {currency}");

                if (!AskAgain("add"))
                {
                    break;
                }
            }
        }

        public static void Withdraw(Wallet wallet, Currency currency)
        {
            while (true)
            {
                Console.WriteLine($"Your current balance is {wallet.GetBalance(currency)} {currency}");
                decimal input = InputHelper.GetAmount("Choose your amount to withdraw: (0 to exit)");
                if (input == 0)
                {
                    Console.WriteLine("Exiting withdraw process.");
                    break;
                }

                if (!wallet.Withdraw(currency, input))
                {
                    Console.WriteLine("Not enough money (or invalid amount). Please try again.");
                    continue;
                }

                Console.WriteLine($"You withdrew {input} {currency}.");
                Console.WriteLine($"Your current balance is {wallet.GetBalance(currency)} {currency}");

                if (!AskAgain("withdraw"))
                {
                    break;
                }
            }
        }

        public static void Convert(Wallet wallet, Currency from, Currency to, decimal rate)
        {
            while (true)
            {
                decimal input = InputHelper.GetAmount($"Enter amount of {from} to exchange: (0 to exit)");
                if (input == 0)
                {
                    break;
                }

                // Take the source money first; only add the converted amount if that succeeds.
                if (!wallet.Withdraw(from, input))
                {
                    Console.WriteLine("Not enough money (or invalid amount). Please try again.");
                    continue;
                }

                decimal converted = input * rate;
                wallet.Deposit(to, converted);

                Console.WriteLine($"You now have {wallet.GetBalance(to)} {to} and {wallet.GetBalance(from)} {from} left.");

                if (!AskAgain("exchange"))
                {
                    break;
                }
            }
        }

        // Shared yes/no prompt used by all three operations.
        private static bool AskAgain(string action)
        {
            Console.WriteLine($"Do you want to {action} more? (yes = 1 / no = 2)");
            return InputHelper.ReadChoice() == "1";
        }
    }
}
