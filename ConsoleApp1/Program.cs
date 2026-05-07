using ConsoleApp1;
using System;

public class Program
{
    public static void Main(string[] args)
    {


        float[] Wallet = new float[5]; //0,1,2,3,4
        Wallet[(int)Currency.PLN] = 1000; //
        Wallet[(int)Currency.EUR] = 0; // 
        Wallet[(int)Currency.USD] = 0;
        Wallet[(int)Currency.KGS] = 0;
        Wallet[(int)Currency.RUB] = 0;

        float[,] exchangeRates = AllExchangeRate.exchangeRates;
        
        Console.WriteLine("Welcome to KrustBank");
        //Console.WriteLine(exchangeRates[(int)Currency.PLN, (int)Currency.EUR]);
        Console.ReadKey();

        Menu.ShowMenu(Wallet, exchangeRates);









    }
}





























//InputHelper.GetFloatInput("")
// Exchange.ExchangeExchange


/*Console.WriteLine("Amount of PLN:");
       Console.WriteLine("Amount of Euro:");

       Wallet[0] = InputHelper.GetFloatInput("Enter Amount of PLN: ");

       Console.WriteLine($"You have {Wallet[0]} PLN in your wallet.");

       Wallet[1] = InputHelper.GetFloatInput("Enter Amount of Euro: ");

       Console.WriteLine($"You have {Wallet[1]} Euro in your wallet.");

       Exchange.ExchangeExchange(ref Wallet[0], ref Wallet[1], euroToPln);*/