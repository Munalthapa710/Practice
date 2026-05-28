using Bulkyweb.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulkyweb.Data
{
    public class ApplicationDbContext:DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; } //create table and after 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { Id = 1, Name = "action ", DisplayOrder = "D1" },
                new Category { Id = 2, Name = "thriller", DisplayOrder = "D2" },
                new Category { Id = 3, Name = "animation ", DisplayOrder = "D3" }



            );
        }
    }
}
