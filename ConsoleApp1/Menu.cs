using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    public static class Menu
    {


        public static string ShowMenu(float[] Wallet, float[,] exchangeRates)  //Menu.ShowMenu(Wallet, exchangeRates);
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine(" Please enter the option: ");
                Console.WriteLine(" ~ Top Up Money . Option - 1");
                Console.WriteLine(" ~ Withdraw Money. Option - 2");
                Console.WriteLine(" ~ Exchange Money. Option - 3"); // add current exchange rate for each currency
                Console.WriteLine(" ~ Current Balance. Option - 4");
                string choice = InputHelper.INput();

                switch (choice)
                {
                    case "1":
                        OptionTopUp(Wallet);
                        break;
                    case "2":
                        OptionWithdraw(Wallet);
                        break;
                    case "3":
                        OptionExchange(Wallet, exchangeRates);
                        break;
                    case "4":
                        OptionBalance(Wallet, exchangeRates);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void OptionTopUp(float[] Wallet)
        {
            while (true)
            {

                Console.WriteLine("You selected Option 1.(Top Up Money)");
                Console.WriteLine("Please select the currency to top up:");
                Console.WriteLine(" PLN = 1");
                Console.WriteLine(" EUR = 2");
                Console.WriteLine(" USD = 3");
                Console.WriteLine(" KGS = 4");
                Console.WriteLine(" RUB = 5");
                Console.WriteLine(" Exit = 0");
                string Cur = InputHelper.INput();
                switch (Cur)
                {
                    case "1":
                        Console.WriteLine("You selected PLN.");
                        Console.WriteLine($"Your Balance: {Wallet[(int)Currency.PLN]} PLN");
                        Exchange.TopUp(Wallet, Currency.PLN, "PLN");
                        break;
                    case "2":
                        Console.WriteLine("You selected EUR.");
                        Console.WriteLine($"Your Balance: {Wallet[(int)Currency.EUR]} EUR");
                        Exchange.TopUp(Wallet, Currency.EUR, "EUR");
                        break;
                    case "3":
                        Console.WriteLine("You selected USD.");
                        Console.WriteLine($"Your Balance: {Wallet[(int)Currency.USD]} USD");
                        Exchange.TopUp(Wallet, Currency.USD, "USD");
                        break;
                    case "4":
                        Console.WriteLine("You selected KGS.");
                        Console.WriteLine($"Your Balance: {Wallet[(int)Currency.KGS]} KGS");
                        Exchange.TopUp(Wallet, Currency.KGS, "KGS");
                        break;
                    case "5":
                        Console.WriteLine("You selected RUB.");
                        Console.WriteLine($"Your Balance: {Wallet[(int)Currency.RUB]} RUB");
                        Exchange.TopUp(Wallet, Currency.RUB, "RUB");
                        break;
                   
                }


            }

        }

        public static void OptionWithdraw(float[] Wallet)
        {

            while (true)
            {
                Console.WriteLine("You selected Option 2. (Withdraw Money)");
                Console.WriteLine("Please select the currency to withdraw:");
                Console.WriteLine(" PLN = 1");
                Console.WriteLine(" EUR = 2");
                Console.WriteLine(" USD = 3");
                Console.WriteLine(" KGS = 4");
                Console.WriteLine(" RUB = 5");
                Console.WriteLine(" Exit = 0");
                string Cur = InputHelper.INput();
              
                switch (Cur)
                {
                    case "1":
                        Console.WriteLine("You selected PLN.");
                        
                        Exchange.Withdraw(Wallet, Currency.PLN, "PLN");
                        break;
                    case "2":
                        Console.WriteLine("You selected EUR.");
                        Exchange.Withdraw(Wallet, Currency.EUR, "EUR");
                        break;
                    case "3":
                        Console.WriteLine("You selected USD.");
                        Exchange.Withdraw(Wallet, Currency.USD, "USD");
                        break;
                    case "4":
                        Console.WriteLine("You selected KGS.");
                        Exchange.Withdraw(Wallet, Currency.KGS, "KGS");
                        break;
                    case "5":
                        Console.WriteLine("You selected RUB.");
                        Exchange.Withdraw(Wallet, Currency.RUB, "RUB");
                        break;
                   
                }
            }
        }



        public static void OptionExchange(float[] Wallet , float[,] exchangeRates)
        {
            while (true)
            {
                Console.WriteLine("You selected Option 3.(Exchange Money");
                Console.WriteLine("Select Your Currency:");
                Console.WriteLine(" PLN = 1");
                Console.WriteLine(" EUR = 2");
                Console.WriteLine(" USD = 3");
                Console.WriteLine(" KGS = 4");
                Console.WriteLine(" RUB = 5");
                Console.WriteLine(" Exit = 0");
                string input = InputHelper.INput();
                
                switch (input)
                {
                    case "1":
                        AllExchangeRate.PLN(Wallet, exchangeRates);
                        break;
                    case "2":
                        AllExchangeRate.EUR(Wallet, exchangeRates);
                        break;
                    case "3":
                        AllExchangeRate.USD(Wallet, exchangeRates);
                        break;
                    case "4":
                        AllExchangeRate.KGS(Wallet, exchangeRates);
                        break;
                    case "5":
                        AllExchangeRate.RUB(Wallet, exchangeRates);
                        break;
                       
                }
            }
        }




        public static void OptionBalance(float[] Wallet, float[,] exchangeRates)
        {
            while (true)
            {

                Console.WriteLine("You selected Option 4. (Check Balance)");
                Console.WriteLine($"PLN: {Wallet[(int)Currency.PLN]}");
                Console.WriteLine($"EUR: {Wallet[(int)Currency.EUR]}");
                Console.WriteLine($"USD: {Wallet[(int)Currency.USD]}");
                Console.WriteLine($"KGS: {Wallet[(int)Currency.KGS]}");
                Console.WriteLine($"RUB: {Wallet[(int)Currency.RUB]}");
                Console.WriteLine("get back to menu - 0");
                Console.WriteLine("Current Exchange Rates:");
                string input = InputHelper.INput();

                if (input == "0")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Sorry in procees of updating exchange rates, you cannot check the balance. Please try again later.");
                    break;
                }

            }
        }
    }
}
