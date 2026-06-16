namespace ConsoleApp1
{
    public static class Menu
    {
        public static void ShowMenu(Wallet wallet)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine(" ~ Top Up Money    - 1");
                Console.WriteLine(" ~ Withdraw Money  - 2");
                Console.WriteLine(" ~ Exchange Money  - 3");
                Console.WriteLine(" ~ Current Balance - 4");
                Console.WriteLine(" ~ Exit            - 0");

                string choice = InputHelper.ReadChoice();
                switch (choice)
                {
                    case "1":
                        OptionTopUp(wallet);
                        break;
                    case "2":
                        OptionWithdraw(wallet);
                        break;
                    case "3":
                        OptionExchange(wallet);
                        break;
                    case "4":
                        OptionBalance(wallet);
                        break;
                    case "0":
                        Console.WriteLine("Thank you for using KrustBank. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void OptionTopUp(Wallet wallet)
        {
            Console.WriteLine("You selected Top Up Money.");
            Currency? currency = AskCurrency("top up");
            if (currency != null)
            {
                Exchange.TopUp(wallet, currency.Value);
            }
        }

        private static void OptionWithdraw(Wallet wallet)
        {
            Console.WriteLine("You selected Withdraw Money.");
            Currency? currency = AskCurrency("withdraw");
            if (currency != null)
            {
                Exchange.Withdraw(wallet, currency.Value);
            }
        }

        private static void OptionExchange(Wallet wallet)
        {
            Console.WriteLine("You selected Exchange Money.");
            Currency? currency = AskCurrency("exchange");
            if (currency != null)
            {
                AllExchangeRate.ShowExchangeMenu(wallet, currency.Value);
            }
        }

        private static void OptionBalance(Wallet wallet)
        {
            Console.WriteLine("You selected Current Balance.");
            foreach (Currency currency in Enum.GetValues<Currency>())
            {
                Console.WriteLine($" {currency}: {wallet.GetBalance(currency)}");
            }
        }

        // Shows the currency list once and returns the chosen currency,
        // or null if the user typed 0 to go back. Used by every option above.
        private static Currency? AskCurrency(string action)
        {
            Currency[] all = Enum.GetValues<Currency>();
            while (true)
            {
                Console.WriteLine($"Please select the currency to {action}:");
                for (int i = 0; i < all.Length; i++)
                {
                    Console.WriteLine($" {all[i]} = {i + 1}");
                }
                Console.WriteLine(" Exit = 0");

                string input = InputHelper.ReadChoice();
                if (input == "0")
                {
                    return null;
                }

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= all.Length)
                {
                    return all[choice - 1];
                }

                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
