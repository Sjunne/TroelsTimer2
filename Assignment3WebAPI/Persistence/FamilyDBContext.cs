using Assignment3WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace Assignment3WebAPI.Persistence
{
    public class FamilyDbContext : DbContext
    {
        public DbSet<Family> Families { get; set; }
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Child> Childs { get; set; }
        public DbSet<ChildInterest> ChildInterests { get; set; }
        public DbSet<Interest> Interests { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = FamilyDBASaS.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Family>().HasKey(family => new
            {
                family.StreetName,
                family.HouseNumber
            });
            
            modelBuilder.Entity<ChildInterest>().HasKey(ci => new
            {
                ci.InterestId,
                ci.ChildId
            });

            modelBuilder.Entity<ChildInterest>()
                .HasOne(childInterest => childInterest.Child)
                .WithMany(child => child.ChildInterests)
                .HasForeignKey(childInterest => childInterest.ChildId);

            modelBuilder.Entity<ChildInterest>()
                .HasOne(childInterest => childInterest.Interest)
                .WithMany(interests => interests.ChildInterests)
                .HasForeignKey(childInterest => childInterest.InterestId);
        }
    }
}