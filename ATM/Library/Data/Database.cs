using Library.Models;

namespace Library.Data
{
    public class Database
    {
        private static readonly Card[] _cards = new Card[5];

        public static void FeedData()
        {
            _cards[0] = new Card("2548896541", "1954");
            _cards[1] = new Card("6547712354", "9668");
            _cards[2] = new Card("1125692546", "0846");
            _cards[3] = new Card("7366932565", "6548");
            _cards[4] = new Card("4984651879", "0684");

        }

        internal static Card? FindCard(string number)
        {
            return _cards.SingleOrDefault(item => item.Number == number);
        }
    }
}
