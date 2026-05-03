using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class InputHelper
    {
       
        public static string INput()
        {
            while (true)
            {
                Console.Write("");
                string choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "0")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                   
                }
            }
        }
        public static float GetFloatInput(string instruction)
        {
            float Answer;
            while (true)
            {
                Console.WriteLine(instruction);
                string input = Console.ReadLine();
                if (float.TryParse(input, out Answer))
                {
                    Console.WriteLine("Success");
                    return Answer;

                }
                else {
                    Console.WriteLine("Invalid input. Please enter a valid number." + instruction);
                }
            }
        }
    }
}
