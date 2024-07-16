using Microsoft.EntityFrameworkCore;
using Sanket_web.Models;

        // application db context is resposbile to conversation to the database.
            
namespace Sanket_web.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
                
        }
        public DbSet<Category> Categories { get; set; }  // it is automatically create table in database table name Category 

        // it is enter record on the database 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
                (
                    new Category { Id = 1 , Name="ramayana" , AddToCart=3},
                    new Category { Id = 2, Name = "Mahabharata", AddToCart = 3 },
                    new Category { Id = 3, Name = "BhagavatGita", AddToCart = 3 }
                );
        }
    }
}
