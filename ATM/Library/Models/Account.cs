namespace Library.Models
{
    public class Account
    {
        public Holder Holder { get; init; }

        public decimal Balance { get; set; }

        public Account()
        {
            Holder = new Holder();

            Balance = RandomizeBalance();
        }

        private static decimal RandomizeBalance()
        {
            int max = 100;

            return Utility.GetRandomInt(max) + Utility.GetRandomDecimal();
        }
    }
}
