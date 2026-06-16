namespace ConsoleApp1
{
    public static class InputHelper
    {
        // Reads one menu choice as text. Each menu's switch decides what is valid,
        // so this helper does not need to know the allowed options.
        public static string ReadChoice()
        {
            string? input = Console.ReadLine();
            return input == null ? "" : input.Trim();
        }

        // Keeps asking until the user types a real number, then returns it.
        public static decimal GetAmount(string instruction)
        {
            while (true)
            {
                Console.WriteLine(instruction);
                string? input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal amount))
                {
                    return amount;
                }

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
