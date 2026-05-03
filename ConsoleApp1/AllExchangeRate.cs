using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class AllExchangeRate
    {
        public static float[,] exchangeRates = new float[5, 5]
         {
    //        PLN     EUR     USD     KGS     RUB
    
    /* PLN */ { 1f,   0.24f,  0.26f,  22.8f,  23.7f },
    /* EUR */ { 4.17f, 1f,    1.08f,  95.1f,  98.7f },
    /* USD */ { 3.87f, 0.93f, 1f,     88.1f,  91.4f },
    /* KGS */ { 0.044f,0.011f,0.011f, 1f,     1.04f },
    /* RUB */ { 0.042f,0.010f,0.011f, 0.96f,  1f    }
         };



    public static void PLN(float[] Wallet , float[,] exchangeRates)
        {
            Console.WriteLine("You selected PLN.");
            Console.WriteLine($"Your Balance: {Wallet[(int)Currency.PLN]} PLN");
            Console.WriteLine("select on option to exchange:");
            Console.WriteLine(" EUR = 1");
            Console.WriteLine(" USD = 2");
            Console.WriteLine(" KGS = 3");
            Console.WriteLine(" RUB = 4");
            Console.WriteLine(" Exit = 0");
            string input = InputHelper.INput();

            switch (input)
            {
                case "1":
                    Console.WriteLine("You selected EUR.");
                    Exchange.ExchangeExchange(Wallet, Currency.PLN, Currency.EUR, exchangeRates[(int)Currency.PLN, (int)Currency.EUR]); // Example rate
                    break;
                case "2":
                    Console.WriteLine("You selected USD.");
                    Exchange.ExchangeExchange(Wallet, Currency.PLN, Currency.USD, exchangeRates[(int)Currency.PLN, (int)Currency.USD]); // Example rate
                    break;
                case "3":
                    Console.WriteLine("You selected KGS.");
                    Exchange.ExchangeExchange(Wallet, Currency.PLN, Currency.KGS, exchangeRates[(int)Currency.PLN, (int)Currency.KGS]); // Example rate
                    break;
                case "4":
                    Console.WriteLine("You selected RUB.");
                    Exchange.ExchangeExchange(Wallet, Currency.PLN, Currency.RUB, exchangeRates[(int)Currency.PLN, (int)Currency.RUB]); // Example rate
                    break;
                }
            }
        public static void EUR(float[] Wallet, float[,] exchangeRates)
        {
            Console.WriteLine("You selected EUR.");
            Console.WriteLine($"Your Balance: {Wallet[(int)Currency.EUR]} EUR");
            Console.WriteLine("select on option to exchange:");
            Console.WriteLine(" PLN = 1");
            Console.WriteLine(" USD = 2");
            Console.WriteLine(" KGS = 3");
            Console.WriteLine(" RUB = 4");
            Console.WriteLine(" Exit = 0");
            string input = InputHelper.INput();

            switch (input)
            {
                case "1":
                    Console.WriteLine("You selected PLN.");
                    Exchange.ExchangeExchange(Wallet, Currency.EUR, Currency.PLN, exchangeRates[(int)Currency.EUR, (int)Currency.PLN]); // Example rate
                    break;
                case "2":
                    Console.WriteLine("You selected USD.");
                    Exchange.ExchangeExchange(Wallet, Currency.EUR, Currency.USD, exchangeRates[(int)Currency.EUR, (int)Currency.USD]); // Example rate
                    break;
                case "3":
                    Console.WriteLine("You selected KGS.");
                    Exchange.ExchangeExchange(Wallet, Currency.EUR, Currency.KGS, exchangeRates[(int)Currency.EUR, (int)Currency.KGS]); // Example rate
                    break;
                case "4":
                    Console.WriteLine("You selected RUB.");
                    Exchange.ExchangeExchange(Wallet, Currency.EUR, Currency.RUB, exchangeRates[(int)Currency.EUR, (int)Currency.RUB]); // Example rate
                    break;
            }
        }
        public static void USD(float[] Wallet, float[,] exchangeRates)
        {
            Console.WriteLine("You selected USD.");
            Console.WriteLine($"Your Balance: {Wallet[(int)Currency.USD]} USD");
            Console.WriteLine("select on option to exchange:");
            Console.WriteLine(" PLN = 1");
            Console.WriteLine(" EUR = 2");
            Console.WriteLine(" KGS = 3");
            Console.WriteLine(" RUB = 4");
            Console.WriteLine(" Exit = 0");
            string input = InputHelper.INput();

            switch (input)
            {
                case "1":
                    Console.WriteLine("You selected PLN.");
                    Exchange.ExchangeExchange(Wallet, Currency.USD, Currency.PLN, exchangeRates[(int)Currency.USD, (int)Currency.PLN]); // Example rate
                    break;
                case "2":
                    Console.WriteLine("You selected EUR.");
                    Exchange.ExchangeExchange(Wallet, Currency.USD, Currency.EUR, exchangeRates[(int)Currency.USD, (int)Currency.EUR]); // Example rate
                    break;
                case "3":
                    Console.WriteLine("You selected KGS.");
                    Exchange.ExchangeExchange(Wallet, Currency.USD, Currency.KGS, exchangeRates[(int)Currency.USD, (int)Currency.KGS]); // Example rate
                    break;
                case "4":
                    Console.WriteLine("You selected RUB.");
                    Exchange.ExchangeExchange(Wallet, Currency.USD, Currency.RUB, exchangeRates[(int)Currency.USD, (int)Currency.RUB]); // Example rate
                    break;
            }
        }
        public static void KGS(float[] Wallet, float[,] exchangeRates)
        {
            Console.WriteLine("You selected KGS.");
            Console.WriteLine($"Your Balance: {Wallet[(int)Currency.KGS]} KGS");
            Console.WriteLine("select on option to exchange:");
            Console.WriteLine(" PLN = 1");
            Console.WriteLine(" EUR = 2");
            Console.WriteLine(" USD = 3");
            Console.WriteLine(" RUB = 4");
            Console.WriteLine(" Exit = 0");
            string input = InputHelper.INput();

            switch (input)
            {
                case "1":
                    Console.WriteLine("You selected PLN.");
                    Exchange.ExchangeExchange(Wallet, Currency.KGS, Currency.PLN, exchangeRates[(int)Currency.KGS, (int)Currency.PLN]); // Example rate
                    break;
                case "2":
                    Console.WriteLine("You selected EUR.");
                    Exchange.ExchangeExchange(Wallet, Currency.KGS, Currency.EUR, exchangeRates[(int)Currency.KGS, (int)Currency.EUR]); // Example rate
                    break;
                case "3":
                    Console.WriteLine("You selected USD.");
                    Exchange.ExchangeExchange(Wallet, Currency.KGS, Currency.USD, exchangeRates[(int)Currency.KGS, (int)Currency.USD]); // Example rate
                    break;
                case "4":
                    Console.WriteLine("You selected RUB.");
                    Exchange.ExchangeExchange(Wallet, Currency.KGS, Currency.RUB, exchangeRates[(int)Currency.KGS, (int)Currency.RUB]); // Example rate
                    break;
            }
        }
        public static void RUB(float[] Wallet, float[,] exchangeRates)
        {
            Console.WriteLine("You selected RUB.");
            Console.WriteLine($"Your Balance: {Wallet[(int)Currency.RUB]} RUB");
            Console.WriteLine("select on option to exchange:");
            Console.WriteLine(" PLN = 1");
            Console.WriteLine(" EUR = 2");
            Console.WriteLine(" USD = 3");
            Console.WriteLine(" KGS = 4");
            Console.WriteLine(" Exit = 0");
            string input = InputHelper.INput();

            switch (input)
            {
                case "1":
                    Console.WriteLine("You selected PLN.");
                    Exchange.ExchangeExchange(Wallet, Currency.RUB, Currency.PLN, exchangeRates[(int)Currency.RUB, (int)Currency.PLN]); // Example rate
                    break;
                case "2":
                    Console.WriteLine("You selected EUR.");
                    Exchange.ExchangeExchange(Wallet, Currency.RUB, Currency.EUR, exchangeRates[(int)Currency.RUB, (int)Currency.EUR]); // Example rate
                    break;
                case "3":
                    Console.WriteLine("You selected USD.");
                    Exchange.ExchangeExchange(Wallet, Currency.RUB, Currency.USD, exchangeRates[(int)Currency.RUB, (int)Currency.USD]); // Example rate
                    break;
                case "4":
                    Console.WriteLine("You selected KGS.");
                    Exchange.ExchangeExchange(Wallet, Currency.RUB, Currency.KGS, exchangeRates[(int)Currency.RUB, (int)Currency.KGS]); // Example rate
                    break;
            }
        }


    }
        
}
