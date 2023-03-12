using Microsoft.EntityFrameworkCore;
using IMS.CoreBusiness;

namespace IMS.Plugins.EFCore
{
    public class IMSContext : DbContext
    {
        public IMSContext(DbContextOptions<IMSContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed some default data for Users
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Name = "John Doe", CPF = 123456789, RG = 987654321, PhoneNumber = "555-1234", Birthdate = new DateTime(1980, 1, 1) },
                new User { UserId = 2, Name = "Jane Smith", CPF = 987654321, RG = 123456789, PhoneNumber = "555-5678", Birthdate = new DateTime(1990, 2, 2) }
            );
        }
    }
}