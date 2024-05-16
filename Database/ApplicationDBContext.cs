using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestAPI.Database.Models;

namespace TestAPI.Database
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        { 
            
        }

        public DbSet<CategoriesModel> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoriesModel>().HasData(
                    new CategoriesModel { CategoryId = 1, CategoryName = "Food"},
                    new CategoriesModel { CategoryId = 2, CategoryName = "Travel" },
                    new CategoriesModel { CategoryId = 3, CategoryName = "Locations" }
                );

        }
    }
}
