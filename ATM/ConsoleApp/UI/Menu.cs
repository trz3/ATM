using Library;
using Library.Models;

namespace ConsoleApp.Ui
{
    internal class Menu
    {
        internal static void Run(Account account)
        {
            bool running = true;

            ConsoleKeyInfo userInput;

            do
            {
                ATM.ShowProjectInfo();

                Console.WriteLine();

                ShowBalance(account.Balance);

                Console.WriteLine();

                Console.WriteLine("1) Deposit");

                Console.WriteLine("2) Withdraw");

                Console.WriteLine("0) Exit");

                Console.WriteLine();

                Console.Write("Please choose one of the option above: ");

                userInput = Console.ReadKey(true);

                Console.Clear();

                decimal amount;

                switch (userInput.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        ATM.ShowProjectInfo();

                        Console.WriteLine();

                        ShowPossibleAmounts();

                        Console.WriteLine();

                        Console.Write("Please select the amount that you wish to deposit: ");

                        amount = GetAmount();

                        Operations.Deposit(account, amount);

                        Console.Clear();

                        ATM.ShowProjectInfo();

                        Console.WriteLine();

                        Console.Write("You successfuly deposited ");

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine(string.Format("{0:C}", amount));

                        Console.ResetColor();

                        Console.WriteLine("Press any key to continue...");

                        Console.ReadLine();

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        ATM.ShowProjectInfo();

                        Console.WriteLine();

                        ShowPossibleAmounts();

                        Console.WriteLine();

                        Console.Write("Please select the amount that you wish to withdraw: ");

                        amount = GetAmount();

                        try
                        {
                            Operations.Withdraw(account, amount);
                        }
                        catch (Exception exception)
                        {
                            Console.Clear();

                            ATM.ShowProjectInfo();

                            Console.WriteLine();

                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine(exception.Message);

                            Console.ResetColor();

                            break;
                        }

                        Console.Clear();

                        ATM.ShowProjectInfo();

                        Console.WriteLine();

                        Console.Write("You successfuly withdrew ");

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine(string.Format("{0:C}", amount));

                        Console.ResetColor();

                        Console.WriteLine("Press any key to continue...");

                        Console.ReadLine();

                        break;

                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        running = false;
                        break;

                    default:
                        break;
                }

                Console.Clear();

            } while (running);
        }

        private static void ShowBalance(decimal balance)
        {
            Console.Write("Current Balance: ");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(string.Format("{0:C}", balance));

            Console.WriteLine();

            Console.ResetColor();
        }

        private static void ShowPossibleAmounts()
        {
            Console.WriteLine(string.Format("1) {0:C}", 10));

            Console.WriteLine(string.Format("2) {0:C}", 20));

            Console.WriteLine(string.Format("3) {0:C}", 50));

            Console.WriteLine(string.Format("4) {0:C}", 100));

            Console.WriteLine(string.Format("5) {0:C}", 250));

            Console.WriteLine(string.Format("6) {0:C}", 500));

            Console.WriteLine(string.Format("7) {0:C}", 1000));
        }

        private static decimal GetAmount()
        {
            ConsoleKeyInfo userInput = Console.ReadKey(true);

            return userInput.Key switch
            {
                ConsoleKey.D1 or ConsoleKey.NumPad1 => 10,

                ConsoleKey.D2 or ConsoleKey.NumPad2 => 20,

                ConsoleKey.D3 or ConsoleKey.NumPad3 => 50,

                ConsoleKey.D4 or ConsoleKey.NumPad4 => 100,

                ConsoleKey.D5 or ConsoleKey.NumPad5 => 250,

                ConsoleKey.D6 or ConsoleKey.NumPad6 => 500,

                ConsoleKey.D7 or ConsoleKey.NumPad7 => 1000,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
