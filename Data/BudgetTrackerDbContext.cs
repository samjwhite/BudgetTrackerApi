using BudgetTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetTracker.Data
{
    public class BudgetTrackerDbContext : DbContext
    {
        public BudgetTrackerDbContext(DbContextOptions<BudgetTrackerDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PlaceOfPurchase> PlacesOfPurchase { get; set; }
        public DbSet<RecordType> RecordTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<UserRecord> UserRecords { get; set; }
        public DbSet<RecordPlaceOfPurchaseCategory> RecordPlaceOfPurchaseCategories { get; set; }
    }
}
