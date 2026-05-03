using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1
{
public static class Exchange
    {
       


        public static void ExchangeExchange(float[] Wallet, Currency from  /*What you want to exchange*/, Currency to , float Rate) // auto choice 100 , 500 , 2000,  ////Exchange.ExchangeExchange(Wallet, 0, 1, Exch Rate)
        {
            while (true) 
            { 
            float input = InputHelper.GetFloatInput("Enter amount to exchange:");
               if(input == 0)
                {
                    break;
                }
               if (input <= Wallet[(int)from] && input > 0)
               {
                   float FinalAmount = input * Rate;
                   Wallet[(int)from] -= input;
                   Wallet[(int)to] += FinalAmount;
                    // Console.WriteLine($"Exchanged {input} at rate {Rate} ");
                    Console.WriteLine($"You now have {Wallet[(int)to]} {to} in the new currency and {Wallet[(int)from]} {from} left ");
                    Console.WriteLine("Do you want to exchange more? (yes = 1 /no = 2)");
                    string choice = InputHelper.INput();
                    if (choice == "1")
                    {
                        continue;
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Exiting top-up process.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                // Exchange.ExchangeExchange
            }
        }




        public static void TopUp(float[] Wallet, Currency currency, string tittle) /*Exchange.TopUp(Wallet, Currency.-Currency-, "-Currency-"); */
        {
            while (true)
            {
                float input = InputHelper.GetFloatInput("");/*select ur  currency*/
                if (input == 0) 
                {
                    Console.WriteLine("Exiting top-up process.");
                    break;
                    
                }
                else if (input < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    continue;
                }
                float FinalAmount = input * 0.98f;

                Wallet[(int)currency] += FinalAmount;
                Console.WriteLine("Tax 2% ");
                Console.WriteLine($"Added: {FinalAmount} , Current balance: {Wallet[(int)currency]} " + tittle);

                Console.WriteLine("Do you want to add more? (yes = 1 /no = 2)");
                string choice = InputHelper.INput();
                if (choice == "1")
                {
                    continue;
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Exiting top-up process.");
                    break;
                }
            }
        }
        public static void Withdraw(float[] Wallet , Currency currency, string tittle) //Exchange.Withdraw(Wallet, Currency.-Currency-, "-Currency-");
        {
            while (true)
            {
                Console.WriteLine($"Your current balance is {Wallet[(int)currency]} " + tittle);

                float input = InputHelper.GetFloatInput("choose your amount to withdraw:");
                Console.Write("Exit = 0 ");
                if (input == 0)
                {
                   Console.WriteLine("Exiting withdraw process. ");
                    break;
                }
                else if(input <= Wallet[(int)currency] && input > 0)        // add limit for withdraw
                {
                    float FinalAmount = Wallet[(int)currency] - input;
                    Wallet[(int)currency] = FinalAmount;
                    Console.WriteLine($"You withdrew this amount {input}" + tittle );
                    Console.WriteLine($"Your current balance is {FinalAmount} " + tittle);
                    Console.WriteLine("Do you want to withdraw more? (yes = 1 /no = 2)");
                    string choice = InputHelper.INput();
                    if (choice == "1")
                    {
                        continue;
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Exiting withdraw process.");
                        break;
                    }
                }
            }
        }
    }
}
