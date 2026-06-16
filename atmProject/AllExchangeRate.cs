namespace ConsoleApp1
{
    // Holds the exchange-rate matrix and shows the "exchange to which currency?" menu.
    public static class AllExchangeRate
    {
        // Rows = currency you have, Columns = currency you want.
        // Read as: 1 unit of [row] is worth this many units of [column].
        public static readonly decimal[,] ExchangeRates = new decimal[5, 5]
        {
            //         PLN      EUR      USD      KGS      RUB
            /* PLN */ { 1m,     0.24m,   0.26m,   22.8m,   23.7m },
            /* EUR */ { 4.17m,  1m,      1.08m,   95.1m,   98.7m },
            /* USD */ { 3.87m,  0.93m,   1m,      88.1m,   91.4m },
            /* KGS */ { 0.044m, 0.011m,  0.011m,  1m,      1.04m },
            /* RUB */ { 0.042m, 0.010m,  0.011m,  0.96m,   1m    }
        };

        // One method handles every "from" currency. It lists all the other
        // currencies, lets the user pick one, then runs the conversion.
        // This replaces the five almost-identical PLN/EUR/USD/KGS/RUB methods.
        public static void ShowExchangeMenu(Wallet wallet, Currency from)
        {
            Console.WriteLine($"You selected {from}.");
            Console.WriteLine($"Your balance: {wallet.GetBalance(from)} {from}");
            Console.WriteLine("Select a currency to exchange to:");

            // Every currency except the one we already hold.
            Currency[] targets = Enum.GetValues<Currency>()
                                     .Where(c => c != from)
                                     .ToArray();

            for (int i = 0; i < targets.Length; i++)
            {
                Console.WriteLine($" {targets[i]} = {i + 1}");
            }
            Console.WriteLine(" Exit = 0");

            string input = InputHelper.ReadChoice();
            if (input == "0")
            {
                return;
            }

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= targets.Length)
            {
                Currency to = targets[choice - 1];
                decimal rate = ExchangeRates[(int)from, (int)to];
                Exchange.Convert(wallet, from, to, rate);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
