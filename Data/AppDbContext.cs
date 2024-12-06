using Microsoft.EntityFrameworkCore;

namespace azure_web_app_sample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }
        
        public DbSet<Person> Persons {get; set; } = null!;


    }

}