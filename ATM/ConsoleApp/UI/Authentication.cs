using Library;
using Library.Models;

namespace ConsoleApp.Ui
{
    internal class Authentication
    {
        internal static void Run(out Account? account)
        {
            bool isAuthSuccessfull;

            do
            {
                string? number;

                string? pin;

                do
                {
                    ATM.ShowProjectInfo();

                    Console.WriteLine();

                    Console.Write("Please insert your card number: ");

                    number = Console.ReadLine();

                    Console.Write("Please insert your pin: ");

                    pin = Console.ReadLine();

                    Console.WriteLine();

                    if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(pin))
                    {
                        ShowAuthFailed();

                        Console.WriteLine("Press any key to try again...");

                        Console.ReadLine();

                        Console.Clear();
                    }

                } while (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(pin));

                Validation.Run(number, pin, out isAuthSuccessfull, out account);

                if (isAuthSuccessfull == false)
                {
                    ShowAuthFailed();

                    Console.WriteLine("Press any key to try again...");

                    Console.ReadLine();

                    Console.Clear();
                }
            } while (isAuthSuccessfull == false || account == null);
        }

        private static void ShowAuthFailed()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Authentication Unsuccessful");

            Console.ResetColor();
        }
    }
}
