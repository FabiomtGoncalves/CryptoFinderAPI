namespace CryptoFinderAPI.Entities
{
    public class Crypto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Symbol { get; set; }
        public string Desc { get; set; } = string.Empty;
    }
}
