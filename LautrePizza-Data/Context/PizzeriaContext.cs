using LautrePizza_Data.Model;
using Microsoft.EntityFrameworkCore;

namespace LautrePizza_Data.Context
{
    public partial class PizzeriaContext : DbContext
    {

        public DbSet<Dish> Disches { get; set; }
        public DbSet<DishType> DischTypes { get ; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=LautrePizza;Username=postgres;Password=ku37fw67");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.DishTypeId).IsRequired();
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });

            modelBuilder.Entity<DishType>(entity =>
            {
               
                entity.Property(e => e.Description).IsRequired();
                entity.Property(e => e.Id).IsRequired();

            });


        }
    }
}