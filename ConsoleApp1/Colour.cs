using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Colour
    {
        public static string Color(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
            return text;
        }
    }
}
