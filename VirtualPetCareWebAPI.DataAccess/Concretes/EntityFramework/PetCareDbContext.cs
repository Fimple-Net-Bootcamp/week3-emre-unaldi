using Microsoft.EntityFrameworkCore;
using VirtualPetCareWebAPI.Entity.Concretes.Entities;

namespace VirtualPetCareWebAPI.DataAccess.Concretes.EntityFramework
{
    public class PetCareDbContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Pet> Pets { get; set; }
        DbSet<HealthStatus> HealthStatuses { get; set; }
        DbSet<Food> Foods { get; set; }
        DbSet<Activity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=PetCareDB;User ID=postgres;Password=admin38;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>()
                .HasOne(p => p.User)
                .WithMany(u => u.Pets)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Pet>()
                .HasOne(p => p.HealthStatus)
                .WithOne(h => h.Pet)
                .HasForeignKey<HealthStatus>(h => h.PetId);

            modelBuilder.Entity<Pet>()
                .HasMany(p => p.Activities)
                .WithOne(a => a.Pet)
                .HasForeignKey(a => a.PetId);

            modelBuilder.Entity<Pet>()
                .HasMany(p => p.Foods)
                .WithOne(f => f.Pet)
                .HasForeignKey(f => f.PetId);
        }
    }
}
