using ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        Wallet wallet = new Wallet();

        Console.WriteLine("Welcome to KrustBank");
        Menu.ShowMenu(wallet);
    }
}
