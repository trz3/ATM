namespace Library.Models
{
    public class Card
    {
        internal Account Account { get; init; }

        internal string Number { get; init; }

        internal string Pin { get; init; }

        public Card(string number, string pin)
        {
            Account = new();

            Number = number;

            Pin = pin;
        }
    }
}
