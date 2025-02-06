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

            }
}
