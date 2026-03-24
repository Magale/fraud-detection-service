using Microsoft.EntityFrameworkCore;
using FraudDetection.Models;

namespace FraudDetection.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Transaction> Transactions => Set<Transaction>();
    }
}
