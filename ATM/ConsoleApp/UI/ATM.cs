using Library.Models;

namespace ConsoleApp.Ui
{
    internal class ATM
    {
        private static readonly string _projectName = "ATM";

        private static readonly string _projectType = "Console Application";

        private static readonly string _projectVersion = "7.0";

        private static readonly bool _running = true;

        internal static void Run()
        {
            do
            {
                Authentication.Run(out Account? account);

                if (account == null)
                    throw new ArgumentException("Account is null");

                string name = account.Holder.GetName();

                GreetUser(name);

                Console.WriteLine();

                Console.WriteLine("Press any key to continue...");

                Console.ReadLine();

                Console.Clear();

                Menu.Run(account);

            } while (_running);
        }

        internal static void ShowProjectInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{_projectName} - {_projectType}: {_projectVersion}");

            Console.ResetColor();
        }

        private static void GreetUser(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Authentication has been successful");

            Console.ResetColor();

            Console.WriteLine($"Welcome {name}!");
        }
    }
}
