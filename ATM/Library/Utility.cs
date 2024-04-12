namespace Library
{
    internal class Utility
    {
        public static Random Random = new();

        public static int GetRandomInt(int max) => Random.Next(max);

        public static decimal GetRandomDecimal() => (decimal)Random.NextDouble();
    }
}
