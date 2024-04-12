using ConsoleApp.Ui;
using Library.Data;
using System.Globalization;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");

            Database.FeedData();

            ATM.Run();
        }
    }
}