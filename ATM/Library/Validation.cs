using Library.Data;
using Library.Models;

namespace Library
{
    public static class Validation
    {
        public static void Run(string number, string pin, out bool isSuccessfull, out Account? account)
        {
            Card? card = Database.FindCard(number);

            if (card != null)
            {
                if (card.Pin == pin)
                {
                    if (card.Account != null)
                    {
                        account = card.Account;

                        isSuccessfull = true;

                        return;
                    }

                    else
                    {
                        throw new NullReferenceException("There is no account linked to this card.");
                    }
                }
            }

            account = null;

            isSuccessfull = false;
        }
    }
}
