using Microsoft.EntityFrameworkCore;

namespace DevExtremeAspNetCoreApp1.Models
{
    public class AppDbContext: DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration, DbContextOptions<AppDbContext> options): base(options) 
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DatabaseConnection"));
            }
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
