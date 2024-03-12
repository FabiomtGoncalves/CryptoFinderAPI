using CryptoFinderAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CryptoFinderAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Crypto> Cryptos { get; set; }

    }
}
