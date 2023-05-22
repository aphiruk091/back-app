using Microsoft.EntityFrameworkCore;
namespace back_app.Models
{
    public class OraDbContext:DbContext
    {
        public DbSet<Employee>Employees{get;set;}
        public OraDbContext(DbContextOptions<OraDbContext>options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}