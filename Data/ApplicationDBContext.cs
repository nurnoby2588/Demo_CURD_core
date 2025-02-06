using Demo_CURD_core.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_CURD_core.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options): base(options) 
        {

        }
        // create Categories table
        public DbSet<Category> Categories { get; set; }

        //inset as default data Categories table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID= 1, CategoryName= "laptop_1", Price=200},
                new Category { CategoryID= 2, CategoryName= "laptop_2", Price=500}, 
                new Category { CategoryID= 3, CategoryName= "laptop_3", Price=100}, 
                new Category { CategoryID= 4, CategoryName= "laptop_4", Price=600}
                
                );
        }
        
    }
}
